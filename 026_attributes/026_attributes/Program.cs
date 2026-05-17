using System;
using System.Collections.Generic;


namespace _026_attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(10, 20));
            Console.WriteLine(Calculator.Add(new List<int>() { 10, 20, 30 }));
        }
    }

    public class Calculator
    {
        [Obsolete]
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(List<int> Numbers)
        {
            int sum = 0;
            foreach(int Number in Numbers)
            {
                sum += Number;
            }

            return sum;
        }
    }
}
