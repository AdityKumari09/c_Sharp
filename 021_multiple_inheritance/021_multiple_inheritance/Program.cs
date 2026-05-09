using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_multiple_inheritance
{
    internal class Program
    {
        interface IPerson
        {
            void GetBasicInfo();
            void DisBasicInfo();
        }

        interface IEducation
        {
            void GetEducationDetails();
            void DisEducationDetails();
        }

        interface IEmployee
        {
            void GetEmploymentDetails();
            void DisEmploymentDetails();
        }

        class Report : IPerson, IEducation, IEmployee
        {
            string name;
            int age, salary;
            string degree;
            float percent;
            string companyName, designation;

            public void GetBasicInfo()
            {
                Console.WriteLine("Enter your name :- ");
                name = Console.ReadLine();

                Console.WriteLine("Enter age :- ");
                age = int.Parse(Console.ReadLine());
            }

            public void DisBasicInfo()
            {
                Console.WriteLine($"Your name is {name} & Your age is {age}");
            }

            public void GetEducationDetails()
            {
                Console.WriteLine("Enter your degree :- ");
                degree = Console.ReadLine();

                Console.WriteLine("Enter your Percentage :- ");
                percent = float.Parse(Console.ReadLine());
            }

            public void DisEducationDetails()
            {
                Console.WriteLine($"Your degree is {degree} & your percentage is {percent}");
            }

            public void GetEmploymentDetails()
            {
                Console.WriteLine("Enter your company name :- ");
                companyName = Console.ReadLine();

                Console.WriteLine("Enter your designation :- ");
                designation = Console.ReadLine();

                Console.WriteLine("Enter your salary :- ");
                salary = int.Parse(Console.ReadLine());
            }

            public void DisEmploymentDetails()
            {
                Console.WriteLine($"You are working in {companyName} as a {designation} for salary {salary}");
            }

            public void GetAllDetails()
            {
                GetBasicInfo();
                GetEducationDetails();
                GetEmploymentDetails();
            }

            public void DisAllDetails()
            {
                DisBasicInfo();
                DisEducationDetails();
                DisEmploymentDetails();
            }
        }
        static void Main(string[] args)
        {
            Report repo = new Report();

            repo.GetAllDetails();
            repo.DisAllDetails();

            Console.ReadKey();
        }
    }
}
