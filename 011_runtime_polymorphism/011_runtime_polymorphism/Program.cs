using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_runtime_polymorphism
{
    internal class Program
    {
        public class Shape
        {
            protected int width, height;

            public Shape(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public virtual int area()
            {
                Console.WriteLine("Parent class method");
                return 0;
            }
        }

        class Rectangle : Shape
        {
            public Rectangle(int a = 0, int b = 0) : base( a, b)
            {

            }

            public override int area()
            {
                return width * height;
            }
        }

        class Triangle : Shape
        {
            public Triangle(int a = 0, int b = 0) : base(a, b)
            {

            }

            //here if we dont write override then parent class area will run.
            public int area()
            {
                return (width * height) / 2;
            }
        }
        static void Main(string[] args)
        {
            Shape s1;

            s1 = new Rectangle(10, 5);
            Console.WriteLine("Area of rectangle {0}", s1.area());

            s1 = new Triangle(4, 8);
            Console.WriteLine("Area of traingle {0}", s1.area());

            Console.ReadKey();
        }
    }
}
