using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_method_hiding
{
    internal class Program
    {
        public class Person
        {
            public void print()
            {
                Console.WriteLine("I am person method.");
            }
        }

        public class Employee : Person
        {
            public new void print()
            {
                Console.WriteLine("I am employee method.");
            }
        }

        public class Manager : Employee
        {
            public new void print()
            {
                Console.WriteLine("I am manager method.");
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.print();

            Employee e = new Employee();
            e.print();
            ((Person)e).print();

            Manager m = new Manager();
            m.print();
            ((Employee)m).print();
            ((Person)m).print();
        }
    }
}
