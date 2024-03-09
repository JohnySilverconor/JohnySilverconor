 
//Chrono Cross Color Field

using System;
using System.Collections.Generic;

namespace ChronoCrossColorField
{
    public static class ColorField
    {
        private static Dictionary<int, int> CF_ELEM_COLORS = new Dictionary<int, int>()
        {
            { 17, 0 },
            { 18, 1 },
            { 19, 2 },
            { 20, 3 },
            { 21, 4 },
            { 22, 5 }
        };

        private static Dictionary<int, int> CF_ELEM_ANTI_COLORS = new Dictionary<int, int>()
        {
            { 0, 1 },
            { 1, 0 },
            { 2, 3 },
            { 3, 2 },
            { 4, 5 },
            { 5, 6 }
        };

        private static Dictionary<int, int> CF_ELEM_SFX = new Dictionary<int, int>()
        {
            { 23, -1 },
            { 24, 1 },
            { 25, 0 },
            { 26, -2 },
            { 27, 2 }
        };

        private static List<int> colorSet = new List<int>();
        private static int colorMax = 6;

        public static void AddColor(int color)
        {
            if (colorSet.Count == colorMax)
            {
                colorSet.RemoveAt(colorSet.Count - 1);
            }
            colorSet.Insert(0, color);
        }

        public static void ResetColorField()
        {
            colorSet.Clear();
        }

        public static double ColorBoost(int color)
        {
            double mod = 1.00;
            int count = 0;
            int antiCount = 0;
            int antiColor = CF_antiColor(color);
            if (colorSet == null)
            {
                return mod;
            }
            foreach (int colorField in colorSet)
            {
                if (colorField == color)
                {
                    mod += CF_COLOR_BONUS;
                }
                if (colorField == antiColor)
                {
                    mod -= CF_ANTI_PENALTY;
                }
                if (colorField == color)
                {
                    count++;
                }
                if (colorField == antiColor)
                {
                    count--;
                }
            }
            if (count == colorMax)
            {
                mod += CF_FULL_BONUS;
            }
            if (count == -colorMax)
            {
                mod -= CF_FULL_PENALTY;
            }
            if (mod < 0.01)
            {
                mod = 0.01;
            }
            return mod;
        }

        private static int CF_antiColor(int color)
        {
            if (CF_ELEM_ANTI_COLORS.ContainsKey(color))
            {
                return CF_ELEM_ANTI_COLORS[color];
            }
            return -1;
        }

        public static int CF_getColor(int elementId)
        {
            int id;
            if (CF_ELEM_COLORS.TryGetValue(elementId, out id))
            {
                return id;
            }
            return -1;
        }

        public static int CF_getColorFromSet(List<int> elementArray)
        {
            foreach (int elementId in elementArray)
            {
                int id;
                if (CF_ELEM_COLORS.TryGetValue(elementId, out id))
                {
                    if (id != -1)
                    {
                        return id;
                    }
                }
            }
            return -1;
        }

        public static bool CF_hasColor(int elementId)
        {
            return (CF_getColor(elementId) != -1);
        }

        public static List<int> CF_getSFXFromSet(List<int> elementArray)
        {
            List<int> sfxArray = new List<int>();
            foreach (int elementId in elementArray)
            {
                int sfx;
                if (CF_ELEM_SFX.TryGetValue(elementId, out sfx))
                {
                    sfxArray.Add(sfx);
                }
            }
            return sfxArray;
        }
    }

    public class Skill
    {
        public List<int> ElementSet { get; set; }

        public Skill(List<int> elementSet)
        {
            ElementSet = elementSet;
        }

        public int Color
        {
            get
            {
                List<int> colorElems = new List<int>();
                foreach (int e in ElementSet)
                {
                    if (ColorField.CF_ELEM_COLORS.ContainsKey(e))
                    {
                        colorElems.Add(e);
                    }
                }
                if (colorElems.Count == 0)
                {
                    colorElems.Add(0);
                }
                return ColorField.CF_getColor(colorElems[0]);
            }
        }

        public bool HasColor
        {
            get
            {
                return (Color != -1);
            }
        }

        public bool SpecialTypeSkill
        {
            get
            {
                List<int> effectSet = ColorField.CF_getSFXFromSet(ElementSet);
                return effectSet.Contains(-2) || effectSet.Contains(-1) || effectSet.Contains(0);
            }
        }
    }

    public class Scene_Battle
    {
        public List<int> ColorSet { get; set; }
        public int ColorMax { get; set; }
        public Battler ActiveBattler { get; set; }

        public Scene_Battle()
        {
            ColorSet = new List<int>();
            ColorMax = ColorField.CF_FIELD_MAX;
        }

        public void AddColor(int color)
        {
            if (ColorSet.Count == ColorMax)
            {
                ColorSet.RemoveAt(ColorSet.Count - 1);
            }
            ColorSet.Insert(0, color);
        }

        public void RefreshColorField()
        {
            // Refresh the color field icons
        }

        public void ResetColorField()
        {
            ColorSet.Clear();
            RefreshColorField();
        }

        public void SetColorField(int newColor)
        {
            for (int i = 0; i < ColorSet.Count; i++)
            {
                ColorSet[i] = newColor;
            }
        }

        public double ColorBoost(int color)
        {
            return ColorField.ColorBoost(color);
        }
    }

    public class Battler
    {
        public int SkillId { get; set; }

        public Battler(int skillId)
        {
            SkillId = skillId;
        }
    }

    public class Game_Battler
    {
        public int ElementsMaxRate(List<int> elementSet)
        {
            int weakest = _orig_elements_max_rate(elementSet);
            if (Scene_Battle is Scene_Battle)
            {
                int color = ColorField.CF_getColorFromSet(elementSet);
                double mod = Scene_Battle.ColorBoost(color);
                weakest = (int)(weakest * mod);
                int skillId = Scene_Battle.ActiveBattler.SkillId;
                Skill skill = null;
                if (skillId > 0)
                {
                    skill = new Skill(skillId);
                }
                if (skill != null)
                {
                    SkillColorFieldFx(skillId, color);
                }
                if (skill != null && skill.SpecialTypeSkill)
                {
                    Scene_Battle.AddColor(ColorField.CF_antiColor(color));
                }
                else
                {
                    if (color != -1)
                    {
                        Scene_Battle.AddColor(color);
                    }
                }
                Scene_Battle.RefreshColorField();
            }
            return weakest;
        }

        private void SkillColorFieldFx(int skillId, int color)
        {
            List<int> elemSet = new List<int>(); // Get the element set for the skill
            List<int> effectSet = ColorField.CF_getSFXFromSet(elemSet);
            foreach (int cfx in effectSet)
            {
                CFSet(cfx, color);
            }
        }

        private void CFSet(int type, int color)
        {
            switch (type)
            {
                case 0:
                    Scene_Battle.ResetColorField();
                    break;
                case -1:
                    if (color != -1)
                    {
                        Scene_Battle.SetColorField(ColorField.CF_antiColor(color));
                    }
                    break;
                case 1:
                    if (color != -1)
                    {
                        Scene_Battle.SetColorField(color);
                    }
                    break;
                case 2:
                    if (color != -1)
                    {
                        Scene_Battle.AddColor(color);
                    }
                    break;
                case -2:
                    if (color != -1)
                    {
                        Scene_Battle.AddColor(ColorField.CF_antiColor(color));
                    }
                    break;
            }
        }
    }

    public class Window_ColorField
    {
        private List<int> colorSet;

        public Window_ColorField(List<int> colorSet)
        {
            this.colorSet = colorSet;
        }

        public void Refresh(List<int> colorSet)
        {
            // Refresh the color field icons
        }
    }
}


//ruby

Chrono Cross Color Field
#  version 1.1
#  by U-Division of ICU Gigasoft
#
#  What is does:
#  -faithfully recreates the skill Color system from the Squaresoft
#   game Chrono Cross
#  -Each skill is assigned a color (or none at all) through elements,
#   and whenver a skill is used it's "color" is added to the battle's
#   color field. The more of a certain color there is, the more
#   powerful the skill of that color becomes.  The field can hold up
#   to a certain number of colors at a time
#  -An extra bonus (or penalty) if the color field is completely one color
#
#  Installation
#  -You need a CF_X.png where X is the ID of the color for every color in the
#   icons folder
#  -Put script above main
#-------------------------------------------------------------------------------
 
#-------------------------------------------------------------------------------
#  Color Field Battel Modifier Configuartion
#-------------------------------------------------------------------------------
 
CF_COLOR_BONUS = 0.10 
#Rate of increase of power for each color the battler's 
#currently used skill on field. Set to 0 to disable.
 
CF_ANTI_PENALTY = 0.10
#Rate of decrease of power for each anti-color of the battler's 
#currently used skill's color on field. Set to 0 to disable.
 
CF_FULL_BONUS = 0.50
#The extra bonus given when the color of the battler's skill completely
#fills the field.
 
CF_FULL_PENALTY = 0.50
#The extra subtraction given when the anti-color of the battler's skill 
#completely fills the field.
 
 
 
#-------------------------------------------------------------------------------
#  Color & Color Field Configuration
#-------------------------------------------------------------------------------
#
#Using the ELEMENT ID fill out the hash like this
#   CF_ELEM_COLORS = {
#   element_id => color_id,
#   element_id => color_id,
#   ...
#   }
CF_ELEM_COLORS = {
17 => 0,
18 => 1,
19 => 2,
20 => 3,
21 => 4,
22 => 5,
}
 
CF_FIELD_MAX = 6 
#Set this to the number of colors, or however many colors you want to be
#remembered.
 
 
#-------------------------------------------------------------------------------
#  Anti Color Configuration
#-------------------------------------------------------------------------------
#
#Using the COLOR ID (as in not the element ID) fill out the hash like this
#   CF_ELEM_ANTI_COLORS = {
#   color_id => anti_color_id,
#   color_id => anti_color_id,
#   ...
#   }
CF_ELEM_ANTI_COLORS = {
0 => 1,
1 => 0,
2 => 3,
3 => 2,
4 => 5,
5 => 6,
}
 
#-------------------------------------------------------------------------------
#  Special Color Effects
#-------------------------------------------------------------------------------
#
# Using the ELEMENT ID fill out the hash like this
#   CF_ELEM_SFX = {
#   element_id => effect,
#   element_id=> effect,
#   ...
#   }
#
#   replace "effect" with one of the following
#  
#   1 : sets the entire field to the color of this skill
#  -1 : sets the entire field to the anti-color of this skill
#   2 : adds an extra color of the skill to the field
#  -2 : adds an extra anti-color of the skill to the field
#   0 : resets the color field to all blank
#
CF_ELEM_SFX = {
23 => -1,
24 => 1,
25 => 0,
26 => -2,
27 => 2,
}
 
 
module Kernel
  def CF_getColor(element_id)
    id = CF_ELEM_COLORS[element_id]
    id = -1 if id == nil
    return id
  end
 
  def CF_getColorFromSet(elementarray)
  for element_id in elementarray
    id = CF_ELEM_COLORS[element_id]
    id = -1 if id == nil
    return id if id != -1
  end
  return -1
  end
  
  def CF_hasColor?(element_id)
    return (getColor(element_id) != -1)
  end
  
  def CF_antiColor(color)
    return CF_ELEM_ANTI_COLORS[color] if CF_ELEM_ANTI_COLORS.has_key?(color)
    return -1
  end
  
  def CF_getSFXFromSet(elementarray)
    sfx_array = []
    for element_id in elementarray
      sfx_array.push(CF_ELEM_SFX[element_id]) if CF_ELEM_SFX.has_key?(element_id)
    end
    return sfx_array
    end
end
 
 
#-------------------------------------------------------------------------------
#  RPG::Skill 
#  new methods:
#      color(color)      :returns the skills color
#      hasColor?         :returns whether or not the skill has a color
#-------------------------------------------------------------------------------
 
module RPG
  class Skill
    
    def color
      color_elems = []
      for e in element_set
        color_elems.push(e) if CF_ELEM_COLORS.include?(e)
      end
      color_elems.push(0) if color_elems.empty?
      return CF_getColor(color_elems[0])
    end
  
    def hasColor?
      return (color != -1)
    end
    
    def special_type_skill?
      effect_set = CF_getSFXFromSet(element_set)
      return effect_set.include?(-2) || effect_set.include?(-1) || effect_set.include?(0)
    end
    
    end
  end
  
#-------------------------------------------------------------------------------
#  Scene_Battle 
#  new methods:
#      add_color(color)      :adds color to color field
#      refresh_color_field   :redraws the icons
#      reset_color_field     :resets color field
#      color_boost(color)    :calculates the damage modifier 
#-------------------------------------------------------------------------------
 
class Scene_Battle
  attr_accessor :color_set
  attr_accessor :color_max
  attr_accessor :active_battler
 
alias :_orig_main :main
def main
  @color_set = []
  @color_max = CF_FIELD_MAX
  @color_icons = Window_ColorField.new(@color_set)
  _orig_main
  @color_icons.dispose
end
 
def add_color(color)
  if @color_set.size == @color_max
    @color_set.pop
  end
  @color_set.unshift(color)
end
 
def refresh_color_field
    @color_icons.refresh(@color_set)
end
 
def reset_color_field
  @color_set = []
  refresh_color_field
end
 
def set_color_field(new_color)
  for i in 0 ... @color_set.size
    @color_set = new_color
    end
end
 
def color_boost(color)
  mod =  1.00
  count = 0
  anti_count = 0
  anti_color = CF_antiColor(color)
  return mod if @color_set == nil
   for color_field in @color_set
     mod += CF_COLOR_BONUS  if color_field == color
     mod -= CF_ANTI_PENALTY if color_field == anti_color
     count += 1 if color_field == color
     count -= 1 if color_field == anti_color
   end
  mod += CF_FULL_BONUS if count == @color_max
  mod -= CF_FULL_PENALTY if count == -@color_max
  mod = 0.01 if mod < 0.01
 return mod
end
 
end
 
#--------------------------------------------------------------------------
# Game_Battler
#---------------------------------------------------------------------------
class Game_Battler
 
#alias :elements_max_rate :elements_correct
alias :_orig_elements_max_rate :elements_max_rate
def elements_max_rate(element_set)
  weakest = _orig_elements_max_rate(element_set)
  if $scene.is_a?(Scene_Battle)
    color = CF_getColorFromSet(element_set)
    mod = $scene.color_boost(color)
    weakest = Integer(weakest*mod)
    skill_id = $scene.active_battler.action.skill_id
    skill = nil
    skill = $data_skills[skill_id] if skill_id > 0
      if skill != nil
        skill_color_field_fx(skill_id,color)
      end
    if skill != nil && skill.special_type_skill?
    $scene.add_color(CF_antiColor(color))
      else
    $scene.add_color(color) if color != -1
    end
    $scene.refresh_color_field
  end
  return weakest
end
 
def skill_color_field_fx(skill_id, color)
  elem_set = $data_skills[skill_id].element_set
  effect_set = CF_getSFXFromSet(elem_set)
  for cfx in effect_set
    cf_set(cfx,color)
  end
end
 
def cf_set(type, color)
  case type
  when 0
    $scene.reset_color_field
  when -1
    if color != -1
    $scene.set_color_field(CF_antiColor(color))
    end
  when 1
    if color != -1
    $scene.set_color_field(color)
    end
  when 2
    if color != -1
    $scene.add_color(color) 
    end
  when -2
    if color != -1
    $scene.add_color(CF_antiColor(color))
    end
  end
  
end
 
end
 
#--------------------------------------------------------------------------
# Window_ColorField
#   Displays the Color icons
#   CF_WINDOW_X = The X Position of the window
#   CF_WINDOW_Y = The Y Position of the window
#--------------------------------------------------------------------------
 
class Window_ColorField < Window_Base
  
  CF_WINDOW_X = 0 #Default is 0
  CF_WINDOW_Y = 0 #Default is 0
  
  #--------------------------------------------------------------------------
  # * Object Initialization
  #--------------------------------------------------------------------------
  def initialize(color_set)
    super(CF_WINDOW_X, CF_WINDOW_Y, 640, 64)
    self.contents = Bitmap.new(width - 32, height - 32)
    self.opacity = 0
    self.z -= 10
    refresh(color_set)
  end
  #--------------------------------------------------------------------------
  # * Refresh
  #--------------------------------------------------------------------------
  def refresh(color_set)
    self.contents.clear
    return if color_set == nil
     count = 0
      for i in color_set
       color_image = "CF_" + i.to_s
       bitmap = Cache.picture(color_image)
       self.contents.blt(x + count*24, y + 4, bitmap, Rect.new(0, 0, 24, 24))
       count += 1
     end
  end
end