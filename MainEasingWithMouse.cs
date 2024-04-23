using System;
using System.Windows.Forms;

namespace EasingWithMouse
{
    public class MainEasingWithMouse : Form
    {
        //Declare constants
        private const double EASING = 0.1;

        //Declare variables
        private double _targetX;
        private double _targetY;

        public MainEasingWithMouse()
        {
            //Initialize variables
            _targetX = player.Location.X;
            _targetY = player.Location.Y;

            //Add event listeners
            this.MouseDown += onMouseDown;
        }

        private void onEnterFrame(object sender, EventArgs e)
        {
            //Calculate the distance from the player to the mouse
            double dx = _targetX - player.Location.X;
            double dy = _targetY - player.Location.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            //Move the object if it is more than 1 pixel away from the mouse
            if (distance >= 1)
            {
                player.Location = new Point((int)(player.Location.X + (_targetX - player.Location.X) * EASING), 
                                            (int)(player.Location.Y + (_targetY - player.Location.Y) * EASING));
            }
            else
            {
                Console.WriteLine("Player reached target");
                this.MouseMove -= onEnterFrame;
            }
        }

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            _targetX = e.X;
            _targetY = e.Y;
            this.MouseMove += onEnterFrame;
        }
    }
}