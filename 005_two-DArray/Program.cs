using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_two_DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[ , ] marks = new int[5, 2] {{72 , 20}, {70 , 21}, {60 , 15}, {73 , 16}, {64, 18}};

            Console.WriteLine("Marks of students are :- ");
            for (int i  = 0; i < 5; i++)
            {
                Console.Write("{ ");

                for (int j = 0; j < 2; j++)
                {
                    Console.Write(marks[i, j] + " ");

                    if (j < 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine("}");
            }
        }
    }
}
