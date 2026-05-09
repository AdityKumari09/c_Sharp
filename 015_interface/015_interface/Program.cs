using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_interface
{
    public interface ICustomer
    {
        void print1(); //public is
    }

    public interface ICustomer2 : ICustomer
    {
        void print2();
    }

    public class Customer : ICustomer2
    {
        public void print1() // we need to implement ICustomer1 interface too because ICutomer2 is implementing ICustomer1 interface.
        {
            Console.WriteLine("Interface 1 print method");
        }
        public void print2()
        {
            Console.WriteLine("Interface 2 print method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ICustomer customer = new Customer(); // we can't create instance of interface but here customer is obj ref variable of type ICustomer1.
            customer.print1(); // we can only call print1 method bcz access depends on the Reference Type not the obj type.

            Customer c1 = new Customer();
            c1.print1();
            c1.print2();
        }
    }
}
