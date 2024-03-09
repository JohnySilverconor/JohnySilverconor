using System;
using System.Collections.Generic;

namespace ConfusionWalk
{
    // Game_Battler class
    public class Game_Battler
    {
        private Dictionary<int, int> confusionCounter;

        public Game_Battler()
        {
            confusionCounter = new Dictionary<int, int>();
        }

        public void AddState(int stateId)
        {
            // Run Original Method
            tds_confusion_walk_game_battler_add_state(stateId);

            // Get state data
            State state = DataManager.GetState(stateId);

            // Step Counter value
            int stepCounter = state.ConfusionSteps;

            // If self is a Game Actor and confusion steps value is not false
            if (this is Game_Actor && stepCounter != 0)
            {
                // Set Confusion Counter Value
                confusionCounter[stateId] = stepCounter;
            }
        }

        public void RemoveState(int stateId)
        {
            // Run Original Method
            tds_confusion_walk_game_battler_remove_state(stateId);

            // If self is a Game Actor and State is included in the confusion counter hash
            if (this is Game_Actor && confusionCounter.ContainsKey(stateId))
            {
                // Delete Confusion Counter State ID from the hash
                confusionCounter.Remove(stateId);
            }
        }
    }

    // Game_Actor class
    public class Game_Actor : Game_Battler
    {
        public Dictionary<int, int> ConfusionCounter { get; private set; }

        public Game_Actor()
        {
            ConfusionCounter = new Dictionary<int, int>();
        }

        public void Setup(int actorId)
        {
            // Confusion Counter Hash
            ConfusionCounter = new Dictionary<int, int>();

            // Run Original Method
            tds_confusion_walk_game_actor_setup(actorId);
        }

        public void DecreaseConfusionCounter()
        {
            // Return if confusion counter hash is empty
            if (ConfusionCounter.Count == 0)
            {
                return;
            }

            // Reduce the values of the confusion counter hash and remove states when they reach 0
            foreach (int stateId in ConfusionCounter.Keys)
            {
                ConfusionCounter[stateId]--;

                if (ConfusionCounter[stateId] <= 0)
                {
                    RemoveState(stateId);
                }
            }
        }
    }

    // Game_Player class
    public class Game_Player : Game_Character
    {
        public bool Confused
        {
            get
            {
                // Return false if confusion counter hash is empty
                if (Game_Party.Members[0].ConfusionCounter.Count == 0)
                {
                    return false;
                }

                // Return false if main actor confusion counter max value is less or equal to 0
                if (Game_Party.Members[0].ConfusionCounter.Values.Max() <= 0)
                {
                    return false;
                }

                // Return true by default
                return true;
            }
        }

        public void IncreaseSteps()
        {
            // Run Original Method
            tds_confusion_walk_game_player_increase_steps();

            // Return if move route forcing (Moving by event command)
            if (MoveRouteForcing)
            {
                return;
            }

            // Decrease Confusion Counter Values
            Game_Party.Members[0].DecreaseConfusionCounter();
        }

        public void MoveByInput()
        {
            // Return if cannot move
            if (!Movable)
            {
                return;
            }

            // Return if game map interpreter is running
            if (Game_Map.Interpreter.Running)
            {
                return;
            }

            switch (Input.Dir4)
            {
                case 2:
                    if (Confused)
                    {
                        MoveUp();
                    }
                    else
                    {
                        MoveDown();
                    }
                    break;
                case 4:
                    if (Confused)
                    {
                        MoveRight();
                    }
                    else
                    {
                        MoveLeft();
                    }
                    break;
                case 6:
                    if (Confused)
                    {
                        MoveLeft();
                    }
                    else
                    {
                        MoveRight();
                    }
                    break;
                case 8:
                    if (Confused)
                    {
                        MoveDown();
                    }
                    else
                    {
                        MoveUp();
                    }
                    break;
            }
        }
    }

    // RPG.State class
    public class State
    {
        public int ConfusionSteps { get; private set; }

        public State(string note)
        {
            // If Notes Include Random Confusion Steps
            if (note.Contains("RAND_CONFUSION_STEPS:"))
            {
                // Check for Random Confusion Steps Information
                var match = System.Text.RegularExpressions.Regex.Match(note, @"RAND_CONFUSION_STEPS: ([0-9]+) ([-0-9]+)");

                // If minimun and maximun matches are not null
                if (match.Success)
                {
                    int sMin = int.Parse(match.Groups[1].Value);
                    int eMax = int.Parse(match.Groups[2].Value);
                    ConfusionSteps = Math.Min(sMin + new Random().Next(eMax), eMax);
                }
            }

            // Check for confusion steps information
            var match2 = System.Text.RegularExpressions.Regex.Match(note, @"CONFUSION_STEPS: ([0-9]+)");

            // Set value
            ConfusionSteps = match2.Success ? int.Parse(match2.Groups[1].Value) : 0;
        }
    }
}

//ruby

* Description:
#  Movement of the character in the map is changed when afflicted with certain
#  status effects.
#------------------------------------------------------------------------------
#  * Features: 
#  Switches the movement on the map to opposites when a character is inflicted
#  with a confuse state.
#
#  Also allows to randomize the amounts of steps needed for the effect to wear
#  off.
#------------------------------------------------------------------------------
#  * Instructions:
#  To use add the confusion step effect add the following a state's note box.
#  
#   CONFUSION_STEPS: DUR
#
#   DUR = Number of steps that the effect will be active for.
#
#   Example:
#
#   CONFUSION_STEPS: 30
#
#  To randomize the number of steps for the effect add the following to a
#  state's notebox.
#
#  RAND_CONFUSION_STEPS: S_MIN E_MAX
#
#  S_MIN = Starting minimun value of steps that the effect will be active for.
#  E_MAX = Ending maximun value of steps that the effect will be active for.
#
#  Example:
#
#  RAND_CONFUSION_STEPS: 10 50
#
#  * The confusion steps effect would last between 10 to 50 steps.  *
#------------------------------------------------------------------------------
#  * Notes:
#    None.
#------------------------------------------------------------------------------
#  * Overwritten Methods:
#  Game_Player:
#  - move_by_input
#    ^ Overwritten to add opposite input effect while confused effect is active.
#------------------------------------------------------------------------------
#  * New Methods:
#  RPG::State Module:
#  - confusion_steps
#    ^ Method used to read confusion steps values and return randomize values
#      when needed.
#
#  Game_Actor:
#  - decrease_confusion_counter
#    ^ Method used to decrease confusion steps values and remove them when needed.
#
#  Game_Player:
#  - confused?
#    ^ Method used to determine if character is under the confused steps effect.
#------------------------------------------------------------------------------
#  * Aliased Methods:
#  Game_Battler:
#  - add_state(state_id)
#    ^ Aliased to add check states for the confusion states effect and apply it.
#  - remove_state(state_id)
#    ^ Aliased to check states for confusion steps and remove effect.
#
#  Game_Actor:
#  - setup(actor_id)
#    ^ Aliased to add and initialize confusion steps counter hash.
#
#  Game_Player:
#  - increase_steps
#    ^ Aliased to modify confusion steps effect values.
#------------------------------------------------------------------------------
# WARNING:
#
# Do not release, distribute or change my work without my expressed written 
# consent, doing so violates the terms of use of this work.
#
# If you really want to share my work please just post a link to the original
# site.
#
# * Not Knowing English or understanding these terms will not excuse you in any
#   way from the consequenses.
#==============================================================================

#==============================================================================
# ** Game_Battler
#------------------------------------------------------------------------------
#  This class deals with battlers. It's used as a superclass of the Game_Actor
# and Game_Enemy classes.
#==============================================================================

class Game_Battler
  #--------------------------------------------------------------------------
  # * Alias Listings
  #--------------------------------------------------------------------------
  alias tds_confusion_walk_game_battler_add_state     add_state     unless $@
  alias tds_confusion_walk_game_battler_remove_state  remove_state  unless $@
  #--------------------------------------------------------------------------
  # * Add State
  #     state_id : state ID
  #--------------------------------------------------------------------------
  def add_state(state_id)
    # Run Original Method
    tds_confusion_walk_game_battler_add_state(state_id)    
    # Get state data
    state = $data_states[state_id]     
    # Step Counter value
    step_counter = state.confusion_steps
    # If self is a Game Actor and confusion steps value is no false
    if self.is_a?(Game_Actor) and step_counter != false
      # Set Confusion Counter Value
      self.confusion_counter[state_id] = step_counter
    end
  end
  #--------------------------------------------------------------------------
  # * Remove State
  #     state_id : state ID
  #-------------------------------------------------------------------------
  def remove_state(state_id)
    # Run Original Method
    tds_confusion_walk_game_battler_remove_state(state_id)    
    # If self is a Game Actor and State is included in the confusion counter hash
    if self.is_a?(Game_Actor) and self.confusion_counter.include?(state_id)
      # Delete Confusion Counter State ID from the hash
      self.confusion_counter.delete(state_id)
    end        
  end
end

#==============================================================================
# ** Game_Actor
#------------------------------------------------------------------------------
#  This class handles actors. It's used within the Game_Actors class
# ($game_actors) and referenced by the Game_Party class ($game_party).
#==============================================================================

class Game_Actor < Game_Battler
  #--------------------------------------------------------------------------
  # * Public Instance Variables
  #--------------------------------------------------------------------------
  attr_accessor :confusion_counter            # Confusion Walking Counter
  #--------------------------------------------------------------------------
  # * Alias Listings
  #--------------------------------------------------------------------------  
  alias tds_confusion_walk_game_actor_setup           setup         unless $@      
  #--------------------------------------------------------------------------
  # * Setup
  #     actor_id : actor ID
  #--------------------------------------------------------------------------
  def setup(actor_id)
    # Confusion Counter Hash
    @confusion_counter = {}
    # Run Original Method
    tds_confusion_walk_game_actor_setup(actor_id)
  end  
  #--------------------------------------------------------------------------
  # * Decrease Confusion Steps Values
  #--------------------------------------------------------------------------
  def decrease_confusion_counter
    # Return if confusion counter hash is empty
    return if @confusion_counter.empty?
    # Reduce the values of the confusion counter hash and remove states when they reach 0
     @confusion_counter.each_key {|state_id| @confusion_counter[state_id] -= 1 ;
     remove_state(state_id) if @confusion_counter[state_id] <= 0}    
  end  
end

#==============================================================================
# ** Game_Player
#------------------------------------------------------------------------------
#  This class handles maps. It includes event starting determinants and map
# scrolling functions. The instance of this class is referenced by $game_map.
#==============================================================================

class Game_Player < Game_Character
  #--------------------------------------------------------------------------
  # * Alias Listings
  #--------------------------------------------------------------------------  
  alias tds_confusion_walk_game_player_increase_steps increase_steps unless $@  
  #--------------------------------------------------------------------------
  # * Determine if Character is Confused
  #--------------------------------------------------------------------------
  def confused?    
    # Return false if confusion counter hash is empty
    return false if $game_party.members[0].confusion_counter.empty?    
    # Return false if main actor confusion counter max value is less or equal to 0
    return false if $game_party.members[0].confusion_counter.values.max <= 0
    # Return true by default
    return true
  end  
  #--------------------------------------------------------------------------
  # * Increase Steps
  #--------------------------------------------------------------------------
  def increase_steps
    # Run Original Method
    tds_confusion_walk_game_player_increase_steps
    # Return if move route forcing (Moving by event command)
    return if @move_route_forcing
    # Decrease Confusion Counter Values
    $game_party.members[0].decrease_confusion_counter    
  end  
  #--------------------------------------------------------------------------
  # * Processing of Movement via input from the Directional Buttons
  #--------------------------------------------------------------------------
  def move_by_input
    # Return if cannot move
    return unless movable?
    # Return if game map interpreter is running
    return if $game_map.interpreter.running?
    case Input.dir4
    when 2;  confused? ? move_up    : move_down
    when 4;  confused? ? move_right : move_left
    when 6;  confused? ? move_left  : move_right 
    when 8;  confused? ? move_down  : move_up
    end
  end
end

#==============================================================================
# ** RPG::State Module
#------------------------------------------------------------------------------
# This module handles state information.
#==============================================================================

module RPG
  class State    
    #--------------------------------------------------------------------------
    # * Get Confusion Steps value
    #--------------------------------------------------------------------------            
    def confusion_steps
      # If Notes Include Random Confusion Steps
      if self.note.include?("RAND_CONFUSION_STEPS:")
        # Check for Random Confusion Steps Information
        self.note[/RAND_CONFUSION_STEPS: ([0-9]+) ([-0-9]+)/]
        # If minimun and maximun matches are not nil
        if ($1 or $2) != nil then return [$1.to_i + rand($2.to_i), $2.to_i].min end
      end
      # Check for confusion steps information  
      self.note[/CONFUSION_STEPS: ([0-9]+)/]
      # Return value
      return $1 == nil ? false : $1.to_i
    end    
  end
end