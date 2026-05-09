using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_inheritance
{
    internal class Program
    {
        public class ParentClass
        {
            public ParentClass()
            {
                Console.WriteLine("Parent class constructor");
            }

            public ParentClass(string message)
            {
                Console.WriteLine(message);
            }
        }

        public class ChildClass : ParentClass
        {
            public ChildClass() : base("To call the Paramtereized constrctor we use this base keyword.")
                // if don't use baseKeyword then default parent customer is callled automatically.  
            {
                Console.WriteLine("Child class constructor");
            }
        }
        static void Main(string[] args)
        {
            ChildClass cc = new ChildClass();
        }
    }
}
