using System;

namespace CountdownTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of half-minute intervals: ");
            int totalTime = int.Parse(Console.ReadLine());
            totalTime *= 30;

            for (int t = totalTime; t >= 0; t--)
            {
                int second = t;
                int hour = second / 3600;
                second %= 3600;
                int minute = second / 60;
                second %= 60;

                // Comment out the following line for testing
                Console.Clear();

                Console.WriteLine($"{hour:D2} : {minute:D2} : {second:D2}");
                System.Threading.Thread.Sleep(1000); // Comment out for testing
            }
        }
    }
}