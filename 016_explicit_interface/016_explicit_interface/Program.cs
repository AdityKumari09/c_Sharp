using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_explicit_interface
{
    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }
    internal class Program : I1, I2
    {
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 interface method implemented.");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 interface method implemented.");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            ((I1)p).InterfaceMethod();
            ((I2)p).InterfaceMethod();
        }
    }
}
