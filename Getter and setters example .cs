using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student{
    private short _ID;
    private string _Name;
    private int _PassMark = 35;

    public short iD
    {
        set
        {
            if (value < 0)
            {
                throw new Exception("Numbers less than zero, are not allowed");
            }
            this._ID = value;
        }
        get
        {
            return this._ID;
        }
    }
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("No letters typed");
            }
            this._Name = Name;
        }
        get
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }
    }
    
    public int Passmark
    {
        get
        {
            return this._PassMark;
        }
    }
}
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.iD = 39;
            C1.Name = "Mark";
            Console.WriteLine("ID = {0}", C1.iD);
            Console.WriteLine("Name = {0}", C1.Name);
            Console.WriteLine("PassMark = {0}", C1.Passmark);
            //C1.ID = 200;
            //C1.Name = null;
            //C1.PassMark = -200;
            //Console.WriteLine("ID = {0}, Name = {1}, PassMark = {2}", C1.ID, C1.Name, C1.PassMark);
            Console.ReadLine();
        }
    }
}
