using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_Delegates
{
    internal class Program
    {
        delegate void demoDelegateFun(string x, int y);

        public static void printDetails(string name, int age)
        {
            Console.WriteLine($"Name = {name}");
            Console.WriteLine($"Age = {age}");
        }

        public static void PrintStringNTimes(string x, int y)
        {
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine(x);
            }
        }
        static void Main(string[] args)
        {
            demoDelegateFun demo;

            demo = new demoDelegateFun(printDetails);
            demo("Adity", 21);

            demo = new demoDelegateFun(PrintStringNTimes);
            demo("CTS", 5);

            Console.ReadKey();
        }
    }
}
