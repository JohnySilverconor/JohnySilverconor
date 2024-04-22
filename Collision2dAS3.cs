/*This JavaScript code defines a class named Collision with a static method block used to detect collisions between two rectangular sprites (r1 and r2). Here is a breakdown of how the collision detection works:

The method calculates the distance vector (vx and vy) between the centers of the two rectangles r1 and r2.
It then checks if the absolute value of vx is less than the sum of half the widths of the two rectangles and if the absolute value of vy is less than the sum of half the heights of the two rectangles.
If both conditions are met, a collision is detected, and the method proceeds to determine the overlap on both the X and Y axes.
Based on the axis with the smallest overlap, it determines the side of the collision (Top, Bottom, Left, or Right) and moves r1 out of the collision by adjusting its position accordingly.
If no collision is detected based on the initial conditions, it sets the collisionSide to "No collision".
Overall, this code provides a basic collision detection mechanism for rectangular sprites in a 2D space, allowing for appropriate handling of collisions based on the side of impact.*/

using System;

public class Collision
{
    public static string collisionSide = "";

    public static void Block(Rectangle r1, Rectangle r2)
    {
        // Calculate the distance vector
        double vx = (r1.X + (r1.Width / 2)) - (r2.X + (r2.Width / 2));
        double vy = (r1.Y + (r1.Height / 2)) - (r2.Y + (r2.Height / 2));

        // Check whether vx is less than the combined half widths
        if (Math.Abs(vx) < r1.Width / 2 + r2.Width / 2)
        {
            // A collision might be occurring! Check whether vy is less than the combined half heights
            if (Math.Abs(vy) < r1.Height / 2 + r2.Height / 2)
            {
                // A collision has occurred! This is good!

                // Find out the size of the overlap on both the X and Y axes
                double overlap_X = r1.Width / 2 + r2.Width / 2 - Math.Abs(vx);
                double overlap_Y = r1.Height / 2 + r2.Height / 2 - Math.Abs(vy);

                // The collision has occurred on the axis with the *smallest* amount of overlap. Let's figure out which axis that is
                if (overlap_X >= overlap_Y)
                {
                    // The collision is happening on the X axis
                    // But on which side? vy can tell us
                    if (vy > 0)
                    {
                        collisionSide = "Top";

                        // Move the rectangle out of the collision
                        r1.Y = r1.Y + overlap_Y;
                    }
                    else
                    {
                        collisionSide = "Bottom";

                        // Move the rectangle out of the collision
                        r1.Y = r1.Y - overlap_Y;
                    }
                }
                else
                {
                    // The collision is happening on the Y axis
                    // But on which side? vx can tell us
                    if (vx > 0)
                    {
                        collisionSide = "Left";

                        // Move the rectangle out of the collision
                        r1.X = r1.X + overlap_X;
                    }
                    else
                    {
                        collisionSide = "Right";

                        // Move the rectangle out of the collision
                        r1.X = r1.X - overlap_X;
                    }
                }
            }
            else
            {
                // No collision
                collisionSide = "No collision";
            }
        }
        else
        {
            // No collision
            collisionSide = "No collision";
        }
    }
static void Main(string[] args)
        {
        }
}

public class Rectangle
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
}