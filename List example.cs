using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] starray = new int[6];
            int lenght = 0;
            int capacity = starray.Length;
            List<string> fruits = new List<string> { "apple", "banana", "orange", "kiwi" };
            int pength = fruits.Count; // length variable will contain 4

        Console.WriteLine($"The length of the array is {length}");
            for (int i = 0; i < 3; i++)
            {
                starray[lenght] = i;
                lenght++;

            }
            starray[lenght] = 8;
            lenght++;

            for(int i = 3; i >= 0; i--)
            {
                starray[i + 3] = starray[1];
                lenght++;

            }

            starray[0] = 20;
            Console.ReadLine();
        }
    }
}
