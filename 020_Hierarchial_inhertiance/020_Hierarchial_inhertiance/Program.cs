using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Hierarchial_inhertiance
{
    internal class Program
    {

        class person
        {
            string name, adhaar, city;
            public void getData()
            {
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                Console.WriteLine("Enter Adhaar");
                adhaar = Console.ReadLine();
                Console.WriteLine("Enter city");
                city = Console.ReadLine();
            }
            public void disData()
            {
                Console.WriteLine("Name  : {0}", name);
                Console.WriteLine("Adhaar: {0}", adhaar);
                Console.WriteLine("City  : {0}", city);
            }
        }

        class employee : person
        {
            int salary;
            public void getSalary()
            {
                Console.WriteLine("Enter Salary");
                salary = int.Parse(Console.ReadLine());
            }
            public void disSalary()
            {
                Console.WriteLine("Salary  : {0}", salary);
            }
        }

        class trainee : person
        {
            int schoAmt;

            public void getSchoAmt()
            {
                Console.WriteLine("Enter scholarship amount");
                schoAmt = int.Parse(Console.ReadLine());
            }

            public void disSchoAmt()
            {
                Console.WriteLine("Scholarship : {0}", schoAmt);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Employee");
            Console.WriteLine("2.Trainee");

            Console.WriteLine("Enter person category (1/2)");
            int PersonCategory = int.Parse(Console.ReadLine());

            switch (PersonCategory)
            {
                case 1:
                    Console.WriteLine("Employee");
                    employee e = new employee();

                    e.getData();
                    e.getSalary();
                    e.disData();
                    e.disSalary();
                    break;
                case 2:
                    Console.WriteLine("Trainee");
                    trainee t = new trainee();

                    t.getData();
                    t.getSchoAmt();
                    t.disData();
                    t.disSchoAmt();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadKey();
        }
    }
}
