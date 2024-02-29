using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consotion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int usernumber = int.Parse(Console.ReadLine());
            if (usernumber == 1)
            {
                Console.WriteLine("Your number is 1.");
            }
            else if (usernumber == 2)
            {
                Console.WriteLine("Your number is 2.");
            }
            else if (usernumber == 3)
            {
                Console.WriteLine("Your number is 3.");
            }
            else
            {
                Console.WriteLine("Your number isn't between 1 and 3: {0}", usernumber);
            }
            //Console.ReadLine();
        }
        
    }
}
