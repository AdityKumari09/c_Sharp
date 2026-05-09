using System;

namespace _019_multilevel_Inheritance
{
    internal class Program
    {
        class Person
        {
            string name, adhaar, city;
            public void getData()
            {
                Console.WriteLine("Enter name ");
                name = Console.ReadLine();

                Console.WriteLine("Enter adhaar ");
                adhaar = Console.ReadLine();

                Console.WriteLine("Enter city ");
                city = Console.ReadLine();
            }

            public void displayData()
            {
                Console.WriteLine("Name : {0}", name);
                Console.WriteLine("Adhaar : {0}", adhaar);
                Console.WriteLine("City : {0}", city);
            }
        }

        class Student : Person
        {
            string course;
            public void getCourse()
            {
                Console.WriteLine("Enter course ");
                course = Console.ReadLine();
            }

            public void displayCourse()
            {
                Console.WriteLine("Course : {0}", course);
            }
        }

        class Employee : Student
        {
            int salary;

            public void getSalary()
            {
                Console.WriteLine("Enter salary ");
                salary = int.Parse(Console.ReadLine());
            }

            public void displaySalary()
            {
                Console.WriteLine("Salary : {0}", salary);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Person");
            Console.WriteLine("2.Student");
            Console.WriteLine("3.Employee");
            Console.WriteLine("Enter person catrgory (1/2/3)");
            int personCategory = int.Parse(Console.ReadLine());

            switch (personCategory)
            {
                case 1:
                    Console.WriteLine("Person");
                    Person p = new Person();
                    p.getData();
                    p.displayData();
                    break;
                case 2:
                    Console.WriteLine("Student");
                    Student s = new Student();
                    s.getData();
                    s.getCourse();
                    s.displayData();
                    s.displayCourse();
                    break;
                case 3:
                    Console.WriteLine("Employee");
                    Employee e = new Employee();
                    e.getData();
                    e.getCourse();
                    e.getSalary();
                    e.displayData();
                    e.displayCourse();
                    e.displaySalary();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }

            Console.ReadKey();
        }
    }
}
