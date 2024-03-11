using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public delegate void SampleDelegates();
public delegate int SampleintDelegates();
namespace Multicastdelegates
{
    
    class Program
    {
        public static void Main(string[] args)
        {
            
            
            
            //other way to delegate
            //SampleDelegates del1, del2, del3, del4;
            //del1 = new SampleDelegates(SampleMethodOne);
            //del2 = new SampleDelegates(SampleMethodTwo);
            //del3 = new SampleDelegates(SampleMethodThree);
            //del4 = del1 + del2 + del3;
            //del4();
            //
            SampleintDelegates intdel1 = new SampleintDelegates(intSampleMethodOne);
            intdel1 += intSampleMethodTwo;
            int delegateReturnValue = intdel1();
            Console.WriteLine("delegateReturnValue = {0}", delegateReturnValue);
            SampleDelegates del1 = new SampleDelegates(SampleMethodOne);
            del1 += SampleMethodTwo;
            del1 += SampleMethodThree;
            del1();
        }
        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }
         public static void SampleMethodTwo()
         {
             Console.WriteLine("SampleMethodTwo Invoked");
        }
         public static void SampleMethodThree()
        {
             Console.WriteLine("SampleMethodThree Invoked");
             Console.ReadLine();
        }
         public static int intSampleMethodOne()
         {
             Console.WriteLine("SampleMethodOne Invoked");
             return 1;
         }
         public static int intSampleMethodTwo()
         {
             Console.WriteLine("SampleMethodOne Invoked");
             return 2;
         }
    }
}
