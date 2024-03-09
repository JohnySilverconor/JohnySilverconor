 /* Define an ActiveEvent class
Dart Event Setup:
In RPG Maker VX, a “dart” event is thrown and interacts with other events.
In C#, we can think of this as an object (representing the dart) interacting with other objects (events).
The dart’s behavior depends on whether it hits an “active” event or a wall.
Active Events:
In RPG Maker VX, “active” events are triggered when the dart hits them.
In C#, we can create classes or methods that represent these active events.
If the dart hits an active event, we can either execute a specific method or toggle a self-switch (similar to RPG Maker’s self-switch behavior).
*/

public class ActiveEvent
{
    public void RunEvent()
    {
        // Logic to run the event when hit by the dart
    }

    public void ToggleSelfSwitchA()
    {
        // Logic to toggle self-switch A
    }
}

/*
In RPG Maker VX, “wall” events behave like walls that the dart can collide with.
In C#, we can represent walls as obstacles or boundaries.
Example in C#:
*/
// Define a Wall class
public class Wall
{
    // Logic to handle collision with the dart
    // (e.g., making the dart disappear)
}

/*
In RPG Maker VX, pass areas allow the dart to pass through specific tiles.
In C#, we can define passable areas using collision detection or tile-based systems.
Example in C#:
*/

// Define a PassArea class
public class PassArea
{
    // Logic to allow the dart to pass through specific tiles
}

// ruby

--------Dart events--------

#

#   A dart event is, simply put, the dart you throw. When it hits an active

#   event, it runs the event, and when it hits a wall, it disappears.

#

#   To set up a 'dart' event, simply put the DART_NAME somewhere in the event

#   name box. Create a second page with the condition 'Self Switch A is ON.'

#   Set its move frequency to Highest and turn on the 'Through' flag. Create 

#   a custom move route with only 'Move Away from Player,' as a condition,

#   and have the 'Repeat Action' flag on. Set the event graphic for the 'A'

#   page to whatever you please.

#

#   --------Active events--------

#

#   'Active' events are what the dart will activate when it hits. When hit, it

#   will either run said event or activate its self-switch.

#

#   To set up an 'active' event, change the event name to this:

#

#

#	 active_name[method][self_switch]

#

#

#   active_name: The name that sets up an 'active' event. Can be set in the

#	 ACTIVE_EVENT_NAME.

#

#   method: Either 'run' or 'SS' without the quotation marks. If set to 'run',

#	 then the event will run as if you activated it regularly through touch

#	 or interaction. If set to 'SS', then the event's self switch will be

#	 turned ON.

#

#   self_switch: The ID of the self switch that will be turned on. Used only

#	 if method is 'SS'. IF NOT USED, KEEP THE BRACKETS BUT LEAVE IT BLANK.

#

#   EXAMPLE NAMES:

#

#	 activate[run][] - When triggered by the dart event, the event will run.

#

#	 activate[SS][A] - When triggered by the dart event, the event's 'A' self

#					   switch will be activated.

#

#   --------Wall events--------

#

#   Wall events behave just like a wall. When the dart runs into it, it will

#   disappear.

#

#   To set up a wall event, simply put 'wall' without the quotation marks

#   somewhere within the event name box.

#

#

#   --------Pass Areas--------

#

#   Pass areas are areas created over tiles that the player can't walk through,

#   but the dart can pass over. You will need to use pass areas over things like

#   pits so the player can't pass over it, but the dart can.

#

#   To set up a pass area, create the area in the event map, and put 'pass' in

#   its area name.
