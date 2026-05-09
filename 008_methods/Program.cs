using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            evenNumber(20);
        }

        public static void evenNumber(int number)
        {
            int start = 0;

            while (start <= number)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
    }
}
