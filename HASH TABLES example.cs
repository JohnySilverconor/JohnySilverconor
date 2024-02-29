using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class HASHTABLES
{
    public string[] myproperty { get; set; }
    public HASHTABLES()
    {
        myproperty = new string[10];
    }
    private int hash(string key)
    {
        return key.Length % myproperty.Length;
    }
    public string Get(string key)
    {
        int hashkey = hash(key);
        return myproperty[hashkey];
    }
    public void Set(string key, string value)
    {
        int hashkey= hash(key);
        if (myproperty[hashkey] != null)
        {
            Console.WriteLine("Sorry hash collision has ocurred");

        }
        else
        {
            myproperty[hashkey] = value;
        }
    }
}
namespace HASH_TABLES
{
    class Program
    {
        static void Main(string[] args)
        {
            HASHTABLES hashtables = new HASHTABLES();
            hashtables.Set("Teddy", "555-0900");
            hashtables.Set("Krillin", "555-9000");
            hashtables.Set("N18", "555-1818");

            Console.WriteLine(hashtables.Get("Teddy"));
            Console.WriteLine(hashtables.Get("Krillin"));
            Console.WriteLine(hashtables.Get("N18"));
            //Console.WriteLine(hashtables.Get(""));
            Console.ReadLine();
        }
    }
}
