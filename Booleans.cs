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
            int number1 = 15;
            int number2 = 220;
            int number10 = 20;
            bool isnumberten;
            bool? areyoumajor = true;
            if (number1 == 15 && number2 == 220)
            {
                Console.WriteLine("hELLO");
            }
            if (areyoumajor == true)
            {

                Console.WriteLine("User is Major.");
            }
            else if (areyoumajor == false)
            {

                Console.WriteLine("User is not a Major.");
            }
            else 
            {

                Console.WriteLine("User did not answer the question");
            
            }
            Console.ReadLine();
            /*}
            if (number10 == 10)
            {
                isnumberten = true;
            }
            else
            {
                isnumberten = false;
                Console.WriteLine("number10 is: {0}", isnumberten);
                Console.ReadLine();
            }*/
        }
    }
}
