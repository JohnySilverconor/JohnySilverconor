using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binarysearch
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public int Search(string input, string[] section, int offset = 0)
        {
            if (section.Length == 0)
            {
                return -1;
            }

            string str = input.ToUpper();
            int firstCharCode = str[0]; // Equivalent to str.charCodeAt(0) in AS3
            string middleWord = section[section.Length / 2];
            int middleWordCharCode = middleWord[0]; // Equivalent to middleWord.charCodeAt(0) in AS3

            if (middleWord.StartsWith(str))
            {
                return (section.Length / 2) + offset;
            }
            else
            {
                int comparison = string.Compare(str, middleWord);
                if (comparison < 0)
                {
                    return Search(input, section.Take(section.Length / 2).ToArray(), offset);
                }
                else // comparison > 0
                {
                    int newOffset = offset + section.Length / 2;
                    return Search(input, section.Skip(section.Length / 2).Take(section.Length - 1).ToArray(), newOffset);
                }
            }
        }
    }
}

// javascript

//public function Search (string:String,section:Array = NewWords, offset:int = 0):int
//{
//    if (section.length == 0) 
//{
//        return -1;
//    }
//    var str:String = string.toUpperCase();
//    var firstCharCode:int = str.charCodeAt(0);
//    var middleWord:String = section[section.length / 2];
//    var middleWordCharCode:int = middleWord.charCodeAt(0);
//    if (middleWord.substr(0,str.length) == str) 
//{
//        return (section.length / 2) + offset;
//    } else 

//{
//        var comparison:int = str.localeCompare(middleWord);
//        if (comparison < 0) 
//{
//            return Search(string, section.splice(0, section.length / 2), offset);
//        } else 
//{ // then comparison > 0
//            var newOffset:int = offset + section.length / 2;
//            return Search(string, section.splice(section.length / 2, section.length-1), newOffset);
//        }
//    }
//}