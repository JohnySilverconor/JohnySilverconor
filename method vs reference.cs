using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace methodsication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program.evennumbers(40);
            //f.evennumbers();
            Program f = new Program();
            int sum = f.addubers(10, 20);
            Console.WriteLine(sum);
            int leep = 0 ;
            simplemethod(ref leep);
            Console.WriteLine(leep);
            Console.ReadLine();
        }
        public int addubers(int FN, int SN)
        {
            return FN + SN;
        }
        public static void simplemethod(ref int j)
        {
            j = 101;
        }
        public static void evennumbers( int target)
    {
        int start = 0;
        while (start <= target)
        {
            Console.WriteLine(start);
            start = start + 2;
        }
     }
   }
}
