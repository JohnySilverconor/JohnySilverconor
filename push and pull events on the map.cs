using System.Collections.Generic;

public class GameMap
{
    private List<GameEvent> pushPullEvents;

    public void SetupEvents()
    {
        // Run Original Method
        tds_event_push_pull_game_map_setup_events();
        // Clear Push and Pull Events
        pushPullEvents = new List<GameEvent>();
        // Go Through Events in map and add push and pull events to list
        foreach (var event in $game_map.events.Values)
        {
            if (event.CanBePushedOrPulled())
            {
                pushPullEvents.Add(event);
            }
        }
    }

    public List<GameEvent> GetPushPullEventsAt(int x, int y)
    {
        List<GameEvent> result = new List<GameEvent>();
        // Go Through Push Pull Events in map and add push and pull events to list
        foreach (var event in pushPullEvents)
        {
            if (event.Pos(x, y))
            {
                result.Add(event);
            }
        }
        return result;
    }
}

public class GameCharacter
{
    public bool CanBePushed { get; set; }
    public bool CanBePulled { get; set; }

    public bool CanBePushedOrPulled()
    {
        return CanBePushed || CanBePulled;
    }

    public bool CollideWithEvents(int x, int y)
    {
        foreach (var event in $game_map.events_xy(x, y))
        {
            if (!event.Through)
            {
                if (this is GameEvent || event.PriorityType == 1)
                {
                    return true;
                }
            }
        }
        if (PriorityType == 1)
        {
            if ($game_map.boat.PosNt(x, y) || $game_map.ship.PosNt(x, y))
            {
                return true;
            }
        }
        return false;
    }
}

public class GameEvent : GameCharacter
{
    public void Setup(EventPage newPage)
    {
        // Run Original Method
        tds_event_push_pull_game_event_setup(newPage);
        // If event name includes Pop Up text Flag
        if (Name.Contains("[MOVABLE]"))
        {
            // Setup Push & Pull Event Properties
            SetupEventPushPull();
        }
    }

    private void SetupEventPushPull()
    {
        CanBePushed = false;
        CanBePulled = false;
        foreach (var command in List)
        {
            if (command.Code == 108 || command.Code == 408)
            {
                if (command.Parameters[0].Contains("CAN_PUSH"))
                {
                    CanBePushed = true;
                }
                if (command.Parameters[0].Contains("CAN_PULL"))
                {
                    CanBePulled = true;
                }
            }
        }
    }
}

public class GamePlayer : GameCharacter
{
    public GameEvent HoldingEvent { get; set; }

    public bool CanPushOrPullEvent()
    {
        if (HoldingEvent == null)
        {
            return false;
        }
        if (HoldingEvent.Moving)
        {
            return false;
        }
        if ($game_map.interpreter.Running)
        {
            return false;
        }
        if (!Movable)
        {
            return false;
        }
        return true;
    }

    public void Update()
    {
        // Run Original Method
        tds_event_push_pull_game_player_update();
        // Update Event Holding
        UpdateEventHolding();
    }

    public void UpdateEventHolding()
    {
        if (HoldingEvent != null && !Input.Press?(Input.C))
        {
            HoldingEvent = null;
            return;
        }
        if (Input.Press?(Input.C) && !Moving && HoldingEvent == null)
        {
            int frontX = $game_map.XWithDirection(X, Direction);
            int frontY = $game_map.YWithDirection(Y, Direction);
            HoldingEvent = $game_map.GetPushPullEventsAt(frontX, frontY).FirstOrDefault();
            return;
        }
    }

    public void MoveByInput()
    {
        if (CanPushOrPullEvent() && Input.Dir4 != 0)
        {
            PushOrPullHeldEvent(Input.Dir4);
            return;
        }
        // Run Original Method
        tds_event_push_pull_game_player_move_by_input();
    }

    public void PushOrPullHeldEvent(int dir)
    {
        if (HoldingEvent == null)
        {
            return;
        }
        if ((dir == 2 || dir == 8) && X != HoldingEvent.X)
        {
            return;
        }
        if ((dir == 4 || dir == 6) && Y != HoldingEvent.Y)
        {
            return;
        }
        int pushSpeed = HoldingEvent.MoveSpeed;
        int recoverSpeed = MoveSpeed;
        var pMoveRoute = new RPG.MoveRoute();
        pMoveRoute.Wait = true;
        pMoveRoute.Skippable = false;
        pMoveRoute.Repeat = false;
        var eMoveRoute = new RPG.MoveRoute();
        eMoveRoute.Wait = true;
        eMoveRoute.Skippable = false;
        eMoveRoute.Repeat = false;
        switch (dir)
        {
            case 2: // Push or Pull Down
                if (Y < HoldingEvent.Y && HoldingEvent.CanBePushed && (Passable?(X, Y + 2) && HoldingEvent.Passable?(X, Y + 2)))
                {
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { recoverSpeed }));
                    pMoveRoute.List.Add(new RPG.MoveCommand(1));
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { pushSpeed }));
                    eMoveRoute.List.Add(new RPG.MoveCommand(1));
                }
                if (Y > HoldingEvent.Y && HoldingEvent.CanBePulled && (Passable?(X, Y + 1) && !HoldingEvent.CollideWithEvents?(X, Y)))
                {
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { recoverSpeed }));
                    pMoveRoute.List.Add(new RPG.MoveCommand(13));
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { pushSpeed }));
                    eMoveRoute.List.Add(new RPG.MoveCommand(1));
                }
                break;
            case 4: // Push or Pull Left
                if (X > HoldingEvent.X && HoldingEvent.CanBePushed && (Passable?(X - 2, Y) && !HoldingEvent.CollideWithEvents?(X - 2, Y)))
                {
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { recoverSpeed }));
                    pMoveRoute.List.Add(new RPG.MoveCommand(12));
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { pushSpeed }));
                    eMoveRoute.List.Add(new RPG.MoveCommand(2));
                }
                if (X < HoldingEvent.X && HoldingEvent.CanBePulled && (Passable?(X - 1, Y) && !HoldingEvent.CollideWithEvents?(X, Y)))
                {
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { recoverSpeed }));
                    pMoveRoute.List.Add(new RPG.MoveCommand(13));
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { pushSpeed }));
                    eMoveRoute.List.Add(new RPG.MoveCommand(2));
                }
                break;
            case 6: // Push or Pull Right
                if (X < HoldingEvent.X && HoldingEvent.CanBePushed && (Passable?(X + 2, Y) && !HoldingEvent.CollideWithEvents?(X + 2, Y)))
                {
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { recoverSpeed }));
                    pMoveRoute.List.Add(new RPG.MoveCommand(12));
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { pushSpeed }));
                    eMoveRoute.List.Add(new RPG.MoveCommand(3));
                }
                if (X > HoldingEvent.X && HoldingEvent.CanBePulled && (Passable?(X + 1, Y) && !HoldingEvent.CollideWithEvents?(X, Y)))
                {
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { recoverSpeed }));
                    pMoveRoute.List.Add(new RPG.MoveCommand(13));
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { pushSpeed }));
                    eMoveRoute.List.Add(new RPG.MoveCommand(3));
                }
                break;
            case 8: // Push or Pull Up
                if (Y > HoldingEvent.Y && HoldingEvent.CanBePushed && (Passable?(X, Y - 2) && HoldingEvent.Passable?(X, Y - 2)))
                {
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { recoverSpeed }));
                    pMoveRoute.List.Add(new RPG.MoveCommand(4));
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { pushSpeed }));
                    eMoveRoute.List.Add(new RPG.MoveCommand(4));
                }
                if (Y < HoldingEvent.Y && HoldingEvent.CanBePulled && (Passable?(X, Y - 1) && !HoldingEvent.CollideWithEvents?(X, Y)))
                {
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { recoverSpeed }));
                    pMoveRoute.List.Add(new RPG.MoveCommand(13));
                    pMoveRoute.List.Add(new RPG.MoveCommand(29, new[] { pushSpeed }));
                    eMoveRoute.List.Add(new RPG.MoveCommand(4));
                }
                break;
        }
        pMoveRoute.List.Reverse();
        eMoveRoute.List.Reverse();
        ForceMoveRoute(pMoveRoute);
        HoldingEvent.ForceMoveRoute(eMoveRoute);
    }
}

//ruby
Description:
#  This script allows you to push and pull events on the map.
#------------------------------------------------------------------------------
#  * Features: 
#  Can push or pull tagged events on the map.
#  Can set to only push or pull events.
#------------------------------------------------------------------------------
#  * Instructions:
#  To make an event be pushed or pulled it must include in it's name:
#  
#  [MOVABLE]
#
#  It must also include a comment in it's "List of command events" with the
#  following:
#
#  CAN_PUSH, CAN_PULL
#  
#  Both are not needed and they do not have to be in a specific order to work.
#  They are simply the pushing and pulling options, if "CAN_PUSH" is not 
#  included then the player will not be able to push that event.
#------------------------------------------------------------------------------
#  * Notes:
#  Depending on the kind of event being pushed or pulled it might be necessary
#  to fix it's direction.
#
#  To lock an event inside an area you could use invisible events to limit 
#  where the event can be pushed or pulled.
#------------------------------------------------------------------------------
#  * New Methods:
#  New Methods here
#  Class_Name:
#  - push_pull_events_xy(x, y)
#    ^ Used to determine events at X, Y coordinates.
#
#  Game_Character:
#  - can_be_pushed_or_pulled?
#    ^ Used to determine if character can be pushed or pulled.
#  - collide_with_events?(x, y)
#    ^ Used to determine collision with other events and not with the player.
#  
#  Game_Event:
#  - setup_event_push_pull
#    ^ Used to setup push and pull settings.
#
#  Game_Player:
#  - can_push_or_pull_event?
#    ^ Used to determine if player can push or pull event.
#  - update_event_holding
#    ^ Used to determine and select event to hold for pushing or pulling.
#  - push_or_pull_held_event(dir)
#    ^ Used to Push or Pull event based on input direction.
#------------------------------------------------------------------------------
#  * Aliased Methods:
#  Aliased methods here
#  Game_Map:
#  - setup_events
#    ^ Aliased to setup movable events and save time when iterating events.
#
#  Game_Character:
#  - initialize
#    ^ Aliased to initialize push and pull flags.
#
#  Game_Event:
#  - setup(new_page)
#    ^ Aliased to start push and pull setup.
#
#  Game_Player:
#  - update
#    ^ Aliased to update pushing and pulling input.
#  - move_by_input
#    ^ Aliased to push or pull any held event when possible.
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
# ** Game_Map
#------------------------------------------------------------------------------
#  This class handles maps. It includes scrolling and passage determination
# functions. The instance of this class is referenced by $game_map.
#==============================================================================

class Game_Map
  #--------------------------------------------------------------------------
  # * Alias Listings
  #--------------------------------------------------------------------------
  alias tds_event_push_pull_game_map_setup_events                setup_events
  #--------------------------------------------------------------------------
  # * Public Instance Variables
  #--------------------------------------------------------------------------
  attr_reader   :push_pull_events                   # Push or Pull events
  #--------------------------------------------------------------------------
  # * Event Setup
  #--------------------------------------------------------------------------
  def setup_events
    # Run Original Method
    tds_event_push_pull_game_map_setup_events 
    # Clear Push and Pull Events
    @push_pull_events = []
    # Go Through Events in map and add push and pull events to array
    $game_map.events.values.each {|event| @push_pull_events << event if event.can_be_pushed_or_pulled?}
  end  
  #--------------------------------------------------------------------------
  # * Get array of push and pull event at designated coordinates
  #     x : x-coordinate
  #     y : y-coordinate
  #--------------------------------------------------------------------------
  def push_pull_events_xy(x, y)
    # Results Array
    result = []    
    # Go Through Push Pull Events in map and add push and pull events to array
    $game_map.push_pull_events.each {|event| result.push(event) if event.pos?(x, y)}
    # Return Results
    return result
  end
end


#==============================================================================
# ** Game_Character
#------------------------------------------------------------------------------
#  This class deals with characters. It's used as a superclass of the
# Game_Player and Game_Event classes.
#==============================================================================

class Game_Character
  #--------------------------------------------------------------------------
  # * Public Instance Variables
  #--------------------------------------------------------------------------
  attr_reader   :move_speed                   # Read Character Move Speed
  attr_accessor :can_be_pushed                # Can be Pushed Flag
  attr_accessor :can_be_pulled                # Can be Pulled Flag
  #--------------------------------------------------------------------------
  # * Alias Listings
  #--------------------------------------------------------------------------    
  alias tds_event_push_pull_game_character_initialize              initialize 
  #--------------------------------------------------------------------------
  # * Object Initialization
  #--------------------------------------------------------------------------
  def initialize
    # Run Original Method
    tds_event_push_pull_game_character_initialize
    # Set Can be Pushed Flag to False (Default)
    @can_be_pushed = false
    # Set Can be Pulled Flag to False (Default)
    @can_be_pulled = false
  end
  #--------------------------------------------------------------------------
  # * Determine if character can be pushed or pulled
  #--------------------------------------------------------------------------
  def can_be_pushed_or_pulled?
    # Return true if Can be pushed or Can be pulled
    return true if @can_be_pushed or @can_be_pulled
    # Return false by default
    return false
  end
  #--------------------------------------------------------------------------
  # * Determine Character Collision
  #     x : x-coordinate
  #     y : y-coordinate
  #    Detects normal character collision, including vehicles.
  #--------------------------------------------------------------------------
  def collide_with_events?(x, y)
    for event in $game_map.events_xy(x, y)          # Matches event position
      unless event.through                          # Passage OFF?
        return true if self.is_a?(Game_Event)       # Self is event
        return true if event.priority_type == 1     # Target is normal char
      end
    end
    if @priority_type == 1                          # Self is normal char
      return true if $game_map.boat.pos_nt?(x, y)   # Matches boat position
      return true if $game_map.ship.pos_nt?(x, y)   # Matches ship position
    end
    return false
  end  
end


#==============================================================================
# ** Game_Event
#------------------------------------------------------------------------------
#  This class deals with events. It handles functions including event page 
# switching via condition determinants, and running parallel process events.
# It's used within the Game_Map class.
#==============================================================================

class Game_Event < Game_Character
  #--------------------------------------------------------------------------
  # * Alias Listings
  #--------------------------------------------------------------------------    
  alias tds_event_push_pull_game_event_setup                            setup 
  #--------------------------------------------------------------------------
  # * Event page setup
  #--------------------------------------------------------------------------
  def setup(new_page)
    # Run Original Method
    tds_event_push_pull_game_event_setup(new_page)    
    # If event name includes Pop Up text Flag
    if @event.name.include?("[MOVABLE]")
      # Setup Push & Pull Event Properties
      setup_event_push_pull    
    end
  end  
  #--------------------------------------------------------------------------
  # * Setup Event Push & Pull Properties
  #--------------------------------------------------------------------------
  def setup_event_push_pull
    # Set Can be Pushed Flag to False
    @can_be_pushed = false
    # Set Can be Pulled Flag to False
    @can_be_pulled = false
    # Go Through Events Commands List
    @list.each do |command|
      # If Command code is 108 (Comment Start) or 408 (Comment Line)
      if command.code == 108 or command.code == 408
        # Set Can be Pushed Flag
        @can_be_pushed = true if command.parameters[0].include?("CAN_PUSH")
        # Set Can be Pulled Flag
        @can_be_pulled = true if command.parameters[0].include?("CAN_PULL")  
      end
    end
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
  # * Public Instance Variables
  #--------------------------------------------------------------------------
  attr_accessor :holding_event               # Event being held by the player
  #--------------------------------------------------------------------------
  # * Alias Listings
  #--------------------------------------------------------------------------
  alias tds_event_push_pull_game_player_update                  update
  alias tds_event_push_pull_game_player_move_by_input           move_by_input
  #--------------------------------------------------------------------------
  # * Determine if Player can Push or Pull Events
  #--------------------------------------------------------------------------
  def can_push_or_pull_event?
    return false if @holding_event.nil?
    return false if @holding_event.moving?
    return false if $game_map.interpreter.running?    
    return false if !movable?    
    return true
  end  
  #--------------------------------------------------------------------------
  # * Frame Update
  #--------------------------------------------------------------------------
  def update
    # Run Original Method
    tds_event_push_pull_game_player_update  
    # Update Event Holding
    update_event_holding
  end    
  #--------------------------------------------------------------------------
  # * Update Event Holding
  #--------------------------------------------------------------------------
  def update_event_holding
    # If Event is not nil and Not pressing C (Confirm)
    if !@holding_event.nil? and !Input.press?(Input::C) 
      # Set Holding Event to nil
      @holding_event = nil
      return
    end
    # If Input Press C (Confirm) and not moving
    if Input.press?(Input::C) and !moving? and @holding_event.nil?
      # Get Front X Position
      front_x = $game_map.x_with_direction(@x, @direction)
      # Get Front Y Position
      front_y = $game_map.y_with_direction(@y, @direction)      
      # Get Holding Event
      @holding_event = $game_map.push_pull_events_xy(front_x, front_y).first
      return
    end    
  end
  #--------------------------------------------------------------------------
  # * Processing of Movement via input from the Directional Buttons
  #--------------------------------------------------------------------------
  def move_by_input
    # If Can Push or Pull Event and trying to move in any direction
    if can_push_or_pull_event? and Input.dir4 != 0      
      # Process Push or Pull of held event
      push_or_pull_held_event(Input.dir4)
      return
    end    
    # Run Original Method
    tds_event_push_pull_game_player_move_by_input        
  end
  #--------------------------------------------------------------------------
  # * Processing of Movement via input from the Directional Buttons
  #--------------------------------------------------------------------------
  def push_or_pull_held_event(dir)
    # Return if Holding Event is nil
    return if @holding_event.nil?
    return if (dir == 2 or dir == 8) and self.x != @holding_event.x
    return if (dir == 4 or dir == 6) and self.y != @holding_event.y
    # Event Pushing Speed
    push_speed = @holding_event.move_speed
    # Player Speed Before Pushing
    recover_speed = @move_speed
    # Player Move Route
    pmove_route = RPG::MoveRoute.new
    pmove_route.wait = true
    pmove_route.skippable = false
    pmove_route.repeat = false
    # Held Event Move Route
    emove_route = RPG::MoveRoute.new
    emove_route.wait = true
    emove_route.skippable = false
    emove_route.repeat = false    
    case dir
    when 2 # Push or Pull Down
      # If Above the Event (Push)
      if self.y < @holding_event.y and @holding_event.can_be_pushed and (passable?(@x, @y + 2) and @holding_event.passable?(@x, @y + 2))
        # Set Player Move Route
        pmove_route.list.push(RPG::MoveCommand.new(29, [recover_speed]), RPG::MoveCommand.new(1), RPG::MoveCommand.new(29, [push_speed]))
        # Set Event Move Route
        emove_route.list.push(RPG::MoveCommand.new(1))
      end      
      # If Below the Event (Pull)
      if self.y > @holding_event.y and @holding_event.can_be_pulled and (passable?(@x, @y + 1) and !@holding_event.collide_with_events?(@x, @y))
        # Set Player Move Route
        pmove_route.list.push(RPG::MoveCommand.new(29, [recover_speed]), RPG::MoveCommand.new(13), RPG::MoveCommand.new(29, [push_speed]))
        # Set Event Move Route
        emove_route.list.push(RPG::MoveCommand.new(1))        
      end
    when 4 # Push or Pull Left
      # If to the Right the Event (Push)
      if self.x > @holding_event.x and @holding_event.can_be_pushed and (passable?(@x - 2, @y) and !@holding_event.collide_with_events?(@x - 2, @y))
        # Set Player Move Route
        pmove_route.list.push(RPG::MoveCommand.new(29, [recover_speed]), RPG::MoveCommand.new(12), RPG::MoveCommand.new(29, [push_speed]))
        # Set Event Move Route
        emove_route.list.push(RPG::MoveCommand.new(2))
      end   
      # If to the Left the Event (Pull)
      if self.x < @holding_event.x and @holding_event.can_be_pulled and (passable?(@x - 1, @y) and !@holding_event.collide_with_events?(@x, @y))
        # Set Player Move Route
        pmove_route.list.push(RPG::MoveCommand.new(29, [recover_speed]), RPG::MoveCommand.new(13), RPG::MoveCommand.new(29, [push_speed]))
        # Set Event Move Route
        emove_route.list.push(RPG::MoveCommand.new(2))
      end
    when 6 # Push or Pull Right
      # If to the Left the Event (Push)
      if self.x < @holding_event.x and @holding_event.can_be_pushed and (passable?(@x + 2, @y) and !@holding_event.collide_with_events?(@x + 2, @y))
        # Set Player Move Route
        pmove_route.list.push(RPG::MoveCommand.new(29, [recover_speed]), RPG::MoveCommand.new(12), RPG::MoveCommand.new(29, [push_speed]))
        # Set Event Move Route
        emove_route.list.push(RPG::MoveCommand.new(3))
      end  
      # If to the Right the Event (Pull)
      if self.x > @holding_event.x and @holding_event.can_be_pulled and (passable?(@x + 1, @y) and !@holding_event.collide_with_events?(@x, @y))
        # Set Player Move Route
        pmove_route.list.push(RPG::MoveCommand.new(29, [recover_speed]), RPG::MoveCommand.new(13), RPG::MoveCommand.new(29, [push_speed]))
        # Set Event Move Route
        emove_route.list.push(RPG::MoveCommand.new(3))
      end      
    when 8 # Push or Pull Up
      # If Below the Event (Push)
      if self.y > @holding_event.y and @holding_event.can_be_pushed and (passable?(@x, @y - 2) and @holding_event.passable?(@x, @y - 2))
        # Set Player Move Route
        pmove_route.list.push(RPG::MoveCommand.new(29, [recover_speed]), RPG::MoveCommand.new(4), RPG::MoveCommand.new(29, [push_speed]))
        # Set Event Move Route
        emove_route.list.push(RPG::MoveCommand.new(4))        
      end
      # If Above the Event (Pull)
      if self.y < @holding_event.y and @holding_event.can_be_pulled and (passable?(@x, @y - 1) and !@holding_event.collide_with_events?(@x, @y))        
        # Set Player Move Route
        pmove_route.list.push(RPG::MoveCommand.new(29, [recover_speed]), RPG::MoveCommand.new(13), RPG::MoveCommand.new(29, [push_speed]))
        # Set Event Move Route
        emove_route.list.push(RPG::MoveCommand.new(4))        
      end      
    end
    # Reverse Move Route Lists (They are executed in reverse)
    pmove_route.list.reverse!    
    emove_route.list.reverse!    
    # Force Player Move Route
    force_move_route(pmove_route)  
    # Force Held Event Move Route
    @holding_event.force_move_route(emove_route)      
  end
end