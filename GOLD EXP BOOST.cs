
using System.Collections.Generic;

namespace RPG
{
    public class BaseItem
    {
        private List<int> _gboosts;
        private List<int> _xboosts;

        public List<int> GoldBoosts
        {
            get
            {
                if (_gboosts != null)
                    return _gboosts;

                _gboosts = new List<int>();
                string[] lines = Note.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    if (line.Contains("<GOLD_BONUS") || line.Contains("<gold bonus"))
                    {
                        int startIndex = line.IndexOf(":") + 1;
                        int endIndex = line.IndexOf("%");
                        string boostValue = line.Substring(startIndex, endIndex - startIndex);
                        _gboosts.Add(int.Parse(boostValue));
                    }
                }

                return _gboosts;
            }
        }

        public List<int> XPBoosts
        {
            get
            {
                if (_xboosts != null)
                    return _xboosts;

                _xboosts = new List<int>();
                string[] lines = Note.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    if (line.Contains("<EXP_BONUS") || line.Contains("<exp bonus") || line.Contains("<XP_BONUS") || line.Contains("<xp bonus"))
                    {
                        int startIndex = line.IndexOf(":") + 1;
                        int endIndex = line.IndexOf("%");
                        string boostValue = line.Substring(startIndex, endIndex - startIndex);
                        _xboosts.Add(int.Parse(boostValue));
                    }
                }

                return _xboosts;
            }
        }

        public string Note { get; set; }
    }

    public class State
    {
        private List<int> _gboosts;
        private List<int> _xboosts;

        public List<int> GoldBoosts
        {
            get
            {
                if (_gboosts != null)
                    return _gboosts;

                _gboosts = new List<int>();
                string[] lines = Note.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    if (line.Contains("<GOLD_BONUS") || line.Contains("<gold bonus"))
                    {
                        int startIndex = line.IndexOf(":") + 1;
                        int endIndex = line.IndexOf("%");
                        string boostValue = line.Substring(startIndex, endIndex - startIndex);
                        _gboosts.Add(int.Parse(boostValue));
                    }
                }

                return _gboosts;
            }
        }

        public List<int> XPBoosts
        {
            get
            {
                if (_xboosts != null)
                    return _xboosts;

                _xboosts = new List<int>();
                string[] lines = Note.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    if (line.Contains("<EXP_BONUS") || line.Contains("<exp bonus") || line.Contains("<XP_BONUS") || line.Contains("<xp bonus"))
                    {
                        int startIndex = line.IndexOf(":") + 1;
                        int endIndex = line.IndexOf("%");
                        string boostValue = line.Substring(startIndex, endIndex - startIndex);
                        _xboosts.Add(int.Parse(boostValue));
                    }
                }

                return _xboosts;
            }
        }

        public string Note { get; set; }
    }

    public class Game_Party
    {
        public List<Actor> Members { get; set; }

        public int PartyGoldRate()
        {
            int n = 100;
            foreach (Actor actor in Members)
            {
                int g_rate = 100;
                foreach (Equip equip in actor.Equips)
                {
                    if (equip == null)
                        continue;

                    int e_g_rate = 100;
                    foreach (int gb in equip.GoldBoosts)
                    {
                        if (gb != null)
                            e_g_rate = e_g_rate * gb / 100;
                    }

                    g_rate = g_rate * e_g_rate / 100;
                }

                foreach (State state in actor.States)
                {
                    int e_g_rate = 100;
                    foreach (int gb in state.GoldBoosts)
                    {
                        if (gb != null)
                            e_g_rate = e_g_rate * gb / 100;
                    }

                    g_rate = g_rate * e_g_rate / 100;
                }

                n = n * g_rate / 100;
            }

            if (n < 0)
                return 0;

            return n;
        }

        public int PartyExpRate()
        {
            int n = 100;
            foreach (Actor actor in Members)
            {
                int x_rate = 100;
                foreach (Equip equip in actor.Equips)
                {
                    if (equip == null)
                        continue;

                    int e_x_rate = 100;
                    foreach (int xb in equip.XPBoosts)
                    {
                        if (xb != null)
                            e_x_rate = e_x_rate * xb / 100;
                    }

                    x_rate = x_rate * e_x_rate / 100;
                }

                foreach (State state in actor.States)
                {
                    int e_x_rate = 100;
                    foreach (int xb in state.XPBoosts)
                    {
                        if (xb != null)
                            e_x_rate = e_x_rate * xb / 100;
                    }

                    x_rate = x_rate * e_x_rate / 100;
                }

                n = n * x_rate / 100;
            }

            if (n < 0)
                return 0;

            return n;
        }
    }

    public class Game_Enemy : Game_Battler
    {
        public int Gold()
        {
            int n = base.Gold();
            n = n * Game_Party.PartyGoldRate() / 100;
            return (int)n;
        }

        public int Exp()
        {
            int n = base.Exp();
            n = n * Game_Party.PartyExpRate() / 100;
            return (int)n;
        }
    }
}
//RUBY

$imported = {} if $imported == nil
$imported["GoldEXPBoost"] = true


 
#==============================================================================
# RPG::BaseItem
#==============================================================================
 
class RPG::BaseItem
 
  #--------------------------------------------------------------------------
  # goldboosts 
  #--------------------------------------------------------------------------

  def goldboosts
    return @gboosts if @gboosts != nil
    @gboosts = []
    self.note.split(/[\r\n]+/).each { |line|
      case line
      when /<(?:GOLD_BONUS|gold bonus):[ ]*(\d+)([%％])>/i
          @gboosts.push($1.to_i)
      end
    }
    return @gboosts
  end
 
  #--------------------------------------------------------------------------
  # xpboosts 
  #--------------------------------------------------------------------------

  def xpboosts
    return @xboosts if @xboosts != nil
    @xboosts = []
    self.note.split(/[\r\n]+/).each { |line|
      case line
      when /<(?:EXP_BONUS|exp bonus|XP_BONUS|xp bonus):[ ]*(\d+)([%％])>/i
          @xboosts.push($1.to_i)
      end
    }
    return @xboosts
  end
 
end
 
#==============================================================================
# RPG::State
#==============================================================================
 
class RPG::State
 
  #--------------------------------------------------------------------------
  # goldboosts 
  #--------------------------------------------------------------------------

  def goldboosts
    return @gboosts if @gboosts != nil
    @gboosts = []
    self.note.split(/[\r\n]+/).each { |line|
      case line
      when /<(?:GOLD_BONUS|gold bonus):[ ]*(\d+)([%％])>/i
          @gboosts.push($1.to_i)
      end
    }
    return @gboosts
  end
 
  #--------------------------------------------------------------------------
  # xpboosts 
  #--------------------------------------------------------------------------

  def xpboosts
    return @xboosts if @xboosts != nil
    @xboosts = []
    self.note.split(/[\r\n]+/).each { |line|
      case line
      when /<(?:EXP_BONUS|exp bonus|XP_BONUS|xp bonus):[ ]*(\d+)([%％])>/i
          @xboosts.push($1.to_i)
      end
    }
    return @xboosts
  end
 
end
 
#==============================================================================
# Game_Party
#==============================================================================
 
class Game_Party
  
  #--------------------------------------------------------------------------
  # new method: party_gold_rate
  #--------------------------------------------------------------------------
  
  def party_gold_rate
    n = 100
    for actor in members
      g_rate = 100
      for equip in actor.equips.compact
        next if equip == nil
        e_g_rate = 100
        equip.goldboosts.each { |gb| e_g_rate = e_g_rate * gb / 100 unless gb == nil }
        g_rate = g_rate * e_g_rate / 100
      end
      for state in actor.states
        e_g_rate = 100
        state.goldboosts.each { |gb| e_g_rate = e_g_rate * gb / 100 unless gb == nil }
        g_rate = g_rate * e_g_rate / 100
      end
      n = n * g_rate / 100 unless g_rate == 100
    end
    return 0 if n < 0
    return n
  end
  
  #--------------------------------------------------------------------------
  # new method: party_exp_rate
  #--------------------------------------------------------------------------
  
  def party_exp_rate
    n = 100
    for actor in members
      x_rate = 100
      for equip in actor.equips.compact
        next if equip == nil
        e_x_rate = 100
        equip.xpboosts.each { |xb| e_x_rate = e_x_rate * xb / 100 unless xb == nil }
        x_rate = x_rate * e_x_rate / 100
      end
      for state in actor.states
        e_x_rate = 100
        state.xpboosts.each { |xb| e_x_rate = e_x_rate * xb / 100 unless xb == nil }
        x_rate = x_rate * e_x_rate / 100
      end
      n = n * x_rate / 100 unless x_rate == 100
    end
    return 0 if n < 0
    return n
  end
  
end
 
#==============================================================================
# Game_Enemy
#==============================================================================
 
class Game_Enemy < Game_Battler
  
  #--------------------------------------------------------------------------
  # alias: gold
  #--------------------------------------------------------------------------
  
  alias csa_gxpb_gold gold unless $@
  def gold
    n = csa_gxpb_gold
    n = n * $game_party.party_gold_rate / 100
    return Integer(n)
  end
  
  #--------------------------------------------------------------------------
  # alias: exp
  #--------------------------------------------------------------------------
  
  alias csa_gxpb_exp exp unless $@
  def exp
    n = csa_gxpb_exp
    n = n * $game_party.party_exp_rate / 100
    return Integer(n)
  end

end
 