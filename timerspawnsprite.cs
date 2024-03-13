using System;

namespace SpriteSpawner
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CountObjectToShow = 10;
            const int TIME_TO_SHOW = 3; // Time interval in seconds

            for (int i = 0; i < CountObjectToShow; i++)
            {
                // Your code to spawn the sprite goes here
                // For example:
                // mole1.visible = true;
                // mole1.paint_sprite(myscreen);

                System.Threading.Thread.Sleep(TIME_TO_SHOW * 1000); // Convert seconds to milliseconds

                // Set object invisible here (if needed)
                // For example:
                // mole1.visible = false;
                // mole1.paint_sprite(myscreen);
            }
        }
    }
}
