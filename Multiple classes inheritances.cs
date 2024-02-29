using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiple_interfaces_inheritances
{
    interface IA {
        void Amethod();
    }
    class A : IA{
        public void Amethod()
        {
            Console.WriteLine("A method");
        }
    }
    interface IB {
        void Bmethod();
    }
    class B : IB {
        public void Bmethod()
        {
            Console.WriteLine("B method");
        }
    }
    class AB : IA, IB
    {
        A a = new A();
            B b = new B();
        public void Amethod()
        {
            a.Amethod();
        }
        public void Bmethod()
        {
            b.Bmethod();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.Amethod();
            ab.Bmethod();
            Console.ReadLine();
        }
    }
}
