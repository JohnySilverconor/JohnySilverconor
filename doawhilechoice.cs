using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doawhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter your target?");
                Int16 UserTarget = Int16.Parse(Console.ReadLine());
                int Start = 0;
                while (Start <= UserTarget)
                {
                    Console.WriteLine(Start + " ");
                    Start = Start + 2;
                }

                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No?");
                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice. Please say Yes or No");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");
        }
    }
}
