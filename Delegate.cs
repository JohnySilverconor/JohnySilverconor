using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegations
{
    public delegate void hellodelegate(string message);
    class Program
    {
        static void Main(string[] args)
        {
            hellodelegate del = new hellodelegate(hello);
            del("hello from delegate");
        }
        public static void hello(string strmessage)
        {
            Console.WriteLine(strmessage);
            Console.ReadLine();
        }
    }
}
