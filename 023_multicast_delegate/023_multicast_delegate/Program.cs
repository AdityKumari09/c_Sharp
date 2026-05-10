using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_multicast_delegate
{
    internal class Program
    {
        public delegate int SampleDelegate();

        public static int SampleMethodOne()
        {
            return 1;
        }

        public static int SampleMethodTwo()
        {
            return 2;
        }
        static void Main(string[] args)
        {
            SampleDelegate d = new SampleDelegate(SampleMethodOne);
            d += SampleMethodTwo;

            int DelegateReturnValue = d();

            Console.WriteLine("Delegate returned values is {0}", DelegateReturnValue);
        }
    }
}
