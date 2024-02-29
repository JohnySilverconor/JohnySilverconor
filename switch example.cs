using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switchation1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int usernumber = int.Parse(Console.ReadLine());
            switch (usernumber)
            {
                case 10:
                case 20:
                case 30:
                Console.WriteLine("Your number is {0}", usernumber);
                break;
                default:
                Console.WriteLine("Your number isn't 10 , 20 & 30");
                break;
                
            }
            Console.ReadLine();
        }
    }
}
