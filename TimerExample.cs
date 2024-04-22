using System;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static Timer timer;
        static int count = 0;

        static void Main(string[] args)
        {
            timer = new Timer(1000);
            timer.Elapsed += TimerElapsed;
            timer.Start();

            Console.ReadLine();
        }

        static void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            count++;
            Console.WriteLine(count);

            if (count == 10)
            {
                count = 0;
            }
        }
    }
}