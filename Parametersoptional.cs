using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace Parametersoptional
{
    class Program
    {
        static void Main(string[] args)
        {
            addnumbers(10, 2200);

            //addnumbers(10, 2200, new int[] { 50, 60, 70});
            //named parameters
            Test(4, c:2);
            Console.ReadLine();

        }
        //method overloading
        public static void addnumbers(int first, int sec) 
        {
            addnumbers(first, sec, null);
        }
        public static void addnumbers(int first, int sec, [Optional]int[]restofnumbers)
        {
            int result = first + sec;
            if (restofnumbers != null) 
            {
                foreach (int i in restofnumbers)
                {
                    result += i;
                }

            }
            Console.WriteLine("Sum = " + result.ToString());
        }
        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }
    }
}
