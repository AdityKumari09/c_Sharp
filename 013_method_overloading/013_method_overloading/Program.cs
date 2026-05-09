using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_method_overloading
{
    internal class Program
    {
        public static int sum(int x)
        {
            return (x + x);
        }

        public static int sum(int x, int y)
        {
            return (x + y);
        }

        public static float sum(float x, float y)
        {
            return (x + y);
        }

        public static void sum(int x, int y, int z)
        {
            int ans = x + y + z;
            Console.WriteLine("Answer is {0}", ans);
        }

        public static void sum(int x, int y, out int z)
        {
            z = x + y;
            Console.WriteLine("Answer is {0}", z);
        }
        static void Main(string[] args)
        {
            int sum1 = sum(10);
            Console.WriteLine("Sum is {0}", sum1);

            int sum2 = sum(10, 20);
            Console.WriteLine("Sum is {0}", sum2);

            float sum3 = sum(2.5f, 2.5f);
            Console.WriteLine("Sum is {0}", sum3);

            sum(10, 20, 30);

            int z = 0;
            sum(10, 20, out z);

            Console.ReadKey();

        }
    }
}
