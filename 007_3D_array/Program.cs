using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_3D_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[ , , ] a = new int[2, 2, 2];
            int batch, student, subject;

            for (batch = 0; batch < 2; batch++)
            {
                Console.WriteLine("Details of batch{0} :- ", batch + 1);

                for (student = 0; student < 2; student++)
                {
                    for (subject = 0; subject < 2; subject++)
                    {
                        Console.WriteLine("Enter the mark{0} of student{1} of batch{2}", subject + 1, student + 1, batch + 1);
                        a[batch, student, subject] = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("Result Proceesed :- ");
            for (batch = 0; batch < 2; batch++)
            {
                Console.WriteLine(batch + 1);
                for (student = 0; student < 2; student++)
                {
                    Console.Write("Student{0}\t", student + 1);
                    for (subject = 0; subject < 2; subject++)
                    {
                        Console.Write("{0}\t", a[batch, student, subject]);
                    }

                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
