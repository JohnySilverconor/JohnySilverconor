using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface ICustomer 
{
    void print();
        //Console.WriteLine("Hello");
}
interface I2
{
    void I2Method();
}
class Customer : ICustomer, I2
{
    //public void print()
    //{
    //    Console.WriteLine("Hello");
    //}
    //public void I2Method()
    //{
    //    Console.WriteLine("print1");
    //}
    void ICustomer.print()
    {
        Console.WriteLine("print1");
    }
    void I2.I2Method()
    {
        Console.WriteLine("print2");
    }
}
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            ((ICustomer)c1).print();
            ((I2)c1).I2Method();
            Console.ReadLine();
        }
    }
}