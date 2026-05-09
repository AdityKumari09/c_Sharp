using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_arays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array (max 10) :- ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            // for this we will take each element input in new line 
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Elements of array are :- ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();

            Console.Write("Partial display of array :- ");
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            Console.Write("Reverse of array :- ");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
