using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public abstract class Customer
{
    public void PRINT()
    {
        Console.WriteLine("Print");
    }
}

public interface ICustomer
{
    void PRINT();
  
}
namespace Abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
