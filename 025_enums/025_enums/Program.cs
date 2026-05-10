using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_enums
{
    internal class Program
    {
        public enum ShiftType
        {
            India = 1, //by default it starts will 0 but here we changed it to 1
            UK,
            US
        }

        public class employee
        {
            public string Name;
            public ShiftType shift;
        }
        static void Main(string[] args)
        {
            employee[] emp = new employee[3];

            for (int i = 0; i < 3; i++)
            {
                emp[i] = new employee();

                Console.WriteLine("Enter name of employee");
                emp[i].Name = Console.ReadLine();

                Console.WriteLine("Enter the shift code 1.India or 2.UK or 3.US");
                emp[i].shift = (ShiftType)int.Parse(Console.ReadLine());
            }

            Console.WriteLine("{0,-20}{1,6}", "Name", "Shift");

            foreach(employee x in emp)
            {
                Console.WriteLine("{0,-20}{1,6}", x.Name, x.shift);
            }

            Console.ReadKey();
        }
    }
}
