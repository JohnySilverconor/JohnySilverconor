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
            //Calculator.Add(10, 20);
            Calculator.Add(new List<int>() { 10, 20, 30, 45 });
        }
    }
    public class Calculator 
    {
        [Obsolete("Use Add(List<int> Numbers) Method", true)]
        public static int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber; ;

        }
        public static int Add(List<int> Numbers)
        {
            int Sum = 0;
            foreach (int Number in Numbers)
            {
                Sum = Sum + Number;
            }
            return Sum;
        }
    }
}
