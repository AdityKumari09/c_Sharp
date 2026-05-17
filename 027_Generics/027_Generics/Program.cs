using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Equal = Calculator<int>.AreEqual(10, 20);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
                Console.WriteLine("Not equal");
        }
    }

    public class Calculator<T>
    {
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
