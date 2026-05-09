using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_conditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee's Name :- ");
            string Employeename = Console.ReadLine();

        ReadMarks:  //goto
            Console.Write("Enter score at Max 10 :- ");
            int score = int.Parse(Console.ReadLine());

            if (score > 10)
            {
                Console.Write("Enter the score less than 10");
                goto ReadMarks;
            }

            if (score >= 7)
            {
                Console.WriteLine($"Hey {Employeename}, you got selected.");
            }

            else
            {
                Console.WriteLine($"Hey {Employeename} you are not selected.");
            }

            Console.ReadKey();
        }
    }
}
