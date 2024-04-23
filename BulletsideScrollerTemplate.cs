using System;

namespace WeaponSystem
{
    public class Weapon
    {
        private bool _isArmed;

        public Weapon()
        {
        }
    }

    public class Bullet
    {
        private int _vx;
        private int _vy;

        public Bullet()
        {
            this.AddedToStage += OnAddedToStage;
        }

        private void OnAddedToStage(object sender, EventArgs e)
        {
            _vx = 0;
            _vy = -10;
            this.X = ((MovieClip)this.Parent).Weapon.X;
            this.Y = ((MovieClip)this.Parent).Weapon.Y;
            this.EnterFrame += OnEnterFrame;
            this.RemovedFromStage += OnRemovedFromStage;
        }

        private void OnRemovedFromStage(object sender, EventArgs e)
        {
            this.EnterFrame -= OnEnterFrame;
            this.AddedToStage -= OnAddedToStage;
            this.RemovedFromStage -= OnRemovedFromStage;
            Console.WriteLine("bullet removed");
        }

        private void OnEnterFrame(object sender, EventArgs e)
        {
            this.Rotation += 20;
            this.X += _vx;
            this.Y += _vy;
            ((MovieClip)this.Parent).CheckCollisionWithEnemies(this);

            if (this.Y + this.Height / 2 < 0)
            {
                this.Parent.RemoveChild(this);
            }
        }
    }
}

/*
package 
{
import flash.display.MovieClip;
import flash.events.Event;
 public class Weapon extends MovieClip
   {
private bool _isArmed;
 public Weapon()
        {
}
}
public class Bullet extends MovieClip
	{
private var _vx:int;
private var _vy:int;
public function Bullet()
		{
addEventListener(Event.ADDED_TO_STAGE, onAddedToStage);
		}
		private function onAddedToStage(event:Event):void
		{//Set the bullet's velocity
_vx = 0;
_vy = -10;
//Set the bullet's start position to be the
//same as the weapon's
x = MovieClip(parent).weapon.x;
y = MovieClip(parent).weapon.y;
addEventListener(Event.ENTER_FRAME, onEnterFrame);
addEventListener(Event.REMOVED_FROM_STAGE, onRemovedFromStage);
		}
		private function onRemovedFromStage(event:Event):void
		{
removeEventListener(Event.ENTER_FRAME, onEnterFrame);
removeEventListener(Event.ADDED_TO_STAGE, onAddedToStage);
removeEventListener(Event.REMOVED_FROM_STAGE, onRemovedFromStage);
trace("bullet removed");
		}
		private function onEnterFrame(event:Event):void
		{
rotation += 20;
//Move the bullet
x += _vx;
y += _vy;
//send DungeonOne_Manager's checkCollisionWithEnemies
//method a reference of this object to check
//for collisions with the enemies
MovieClip(parent).checkCollisionWithEnemies(this);
//Remove the bullet if it moves 
//beyond the top of the stage
			if (y + height / 2 < 0)
			{parent.removeChild(this);
			}
		}*/