using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_2D_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students :- ");
            int studentCount = int.Parse(Console.ReadLine());

            int[,] marks = new int[studentCount, 2];
            Console.WriteLine($"Enter marks of {studentCount} Students");

            for (int student = 0; student < studentCount; student++)
            {
                Console.WriteLine($"Enter internal and external marks of student {student + 1}");

                for (int sub = 0; sub < 2; sub++)
                {
                    marks[student, sub] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"{"Student",-12}{"Internal",10}{"External",10}");
            Console.WriteLine("========================================================");
            for (int student = 0; student < studentCount; student++)
            {
                Console.Write($"Student{student + 1:00}");

                for (int sub = 0; sub < 2; sub++)
                {
                    Console.Write($"{marks[student, sub],10}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("=========================================================");
            Console.ReadKey();
        }
    }
}
