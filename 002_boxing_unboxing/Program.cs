using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_boxing_unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i; // Boxing :- value type is converted into ref type, a copy of i placed in heap.

            o = "Adity";
            string name = (string)o;
            /*
                Explicit casting is required to convert a base type(object) to a derived type (string).
                aka downcasting.

                Also typecasting is required bcz at compile time the variable o is of the object time and the complier
                needs an explicit cast to safely convert it to a string.
             */

            o = 100; //again boxing, the actual type inside o is still int, but wrapped as object.
            int j = (int)o; //unboxing, at runtime checks if o actually contains boxed int, if yes extract value and copies value to j.

            o = 'x';
            o = 45.63f;
            /*
                o stops pointing to 'x'. A new boxed float object is created in the heap, x is unreferenced, eligible for gc.
             */

            Console.Write(o);
        }
    }
}
