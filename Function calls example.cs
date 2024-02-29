using System;
    class Program
    {
        
        static void Main1()
        {
            System.Console.WriteLine("Hello World!");
        }
        static void Main()
        {
            int numerator = 0;
            int sumerator;
            int result = numerator;
            string oname = "New Name\nAsh\nTerry\nRed";
            System.Console.WriteLine(oname);
            System.Console.WriteLine("Please Enter your name: ");
            string username = Console.ReadLine();
            System.Console.WriteLine("Please Enter your profession: ");
            string jobname = Console.ReadLine();
            Main1();
            Console.WriteLine("Hello World! for you: {0}, {1}" , username,jobname);
            Main1();
            System.Console.ReadLine();

        }
    }
