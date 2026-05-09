using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_abstract_class
{
    abstract class Shape
    {
        public abstract int area();

        public void display()
        {
            Console.WriteLine("Hii I'm abstract class");
        }
    }

    class Square : Shape
    {
        private int side;
        public Square(int x)
        {
            side = x;
        }

        public override int area()
        {
            Console.Write("Area of square :- ");
            return (side * side);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(4);
            double result = s.area();
            Console.WriteLine(result);

            Shape s1 = new Square(5);
            s1.display();
        }
    }
}
