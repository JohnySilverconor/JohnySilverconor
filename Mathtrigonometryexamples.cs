using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anonymous_functions
{
    using System;

public class Math2
{
    /**
     * Convert given degree into radian
     * @param deg Angle in degree
     * @return Angle in radian
     */
    public static double RadianOf(double deg)
    {
        return deg / 180 * Math.PI;
    }

    /**
     * Convert given radian into degree
     * @param rad Angle in radian
     * @return Angle in degree
     */
    public static double DegreeOf(double rad)
    {
        return rad / Math.PI * 180;
    }

    /**
     * Perform Pyhtagoras' Theorem on lengths
     * @param xDist
     * @param yDist
     * @return
     */
    public static double Pythagoras(double xDist, double yDist)
    {
        return Math.Sqrt(xDist * xDist + yDist * yDist);
    }

    /**
     * Perform cosine rule to calculate the angle between b and c
     * @param a Side of triangle
     * @param b Side of triangle
     * @param c Side of triangle
     * @return angle sandwiched between b and c
     */
    public static double CosineRule(double a, double b, double c)
    {
        double angle = (b * b + c * c - a * a) / (2 * b * c);
        return Math.Cos(angle);
    }

    /**
     * Bound input value between range
     * @param lowerBound Minimum value allowed
     * @param upperBound Maximum value allowed
     * @param input Current value to bound
     * @return A value within boundaries
     */
    public static double ImplementBound(double lowerBound, double upperBound, double input)
    {
        return Math.Min(Math.Max(lowerBound, input), upperBound);
    }
    static void Main(string[] args)
    {

    }
  }
}