using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_out_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int product = 0;
            calculate(20, 30, out total, out product);

            Console.WriteLine("Total = {0} and Product = {1} ", total, product);
        }

        public static void calculate(int firstNumber, int secondNumber, out int sum, out int product)
        {
            sum = firstNumber + secondNumber;
            product = firstNumber * secondNumber;
        }
    }
}
