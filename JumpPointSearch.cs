using System;
using System.Collections.Generic;

public class 
{
    public static List<Point> FindPath(bool[,] grid, Point start, Point end)
    {
        // Your implementation here
    }

    private static List<Point> GetNeighbors(Point current, bool[,] grid)
    {
        // Your implementation here
    }

    private static Point Jump(Point current, Point direction, Point end, bool[,] grid)
    {
        // Your implementation here
    }

    // Other necessary methods and logic for JPS
}

public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}
