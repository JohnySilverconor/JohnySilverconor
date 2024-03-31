using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stringbuilder
{
    class Stringbuilder
    {
        static void Main(string[] args)
        {
           ////1000 instances of strings
           // string strNumbers = string.Empty;
           // for (int i = 0; i < 1000; i++)
           // {
           //     strNumbers += i.ToString() + " ";
           // }
           // Console.WriteLine(strNumbers);

            // 1 instance the last value
            StringBuilder mynumber = new StringBuilder();
                for (int i = 0; i <= 1000; i++)
            {
                mynumber.Clear();
                mynumber.Append(i).Append(" ");
                //mynumber += i.ToString() + " ";
            }
                Console.WriteLine(mynumber);


            //5 instances of strings
            //string userString = "C#";
            //userString += " Video";
            //userString += " Tutorial";
            //userString += " for";
            //userString += " beginners";
            //Console.WriteLine(userString);

            //1 instances of string
            StringBuilder userStringBuilder = new StringBuilder("C#");
            userStringBuilder.Append(" Video");
            userStringBuilder.Append(" Tutorial");
            userStringBuilder.Append(" for");
            userStringBuilder.Append(" beginners");
            Console.WriteLine(userStringBuilder.ToString());
            Console.ReadLine();
        }
    }
}
