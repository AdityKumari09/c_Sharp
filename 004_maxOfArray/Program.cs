using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_maxOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array :- ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter the elements of array :- ");
            string[] input = Console.ReadLine().Split(' ');

            if(input.Length != n)
            {
                Console.WriteLine("Invalid input, Expected " + n + " elements.");
                return;
            }

            int[] arr = input.Select(int.Parse).ToArray();

            int max = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine($"Maximum element is {max}");
        }
    }
}

