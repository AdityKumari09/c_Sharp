using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_hirerachial_inheritance_usingIterface
{
    internal class Program
    {
        public interface IArea
        {
            void findArea();
        }

        public class Circle : IArea
        {
            float radius, area;

            public Circle(float r)
            {
                radius = r;
                Console.WriteLine("Radius is {0}", radius);
            }

            public void findArea()
            {
                area = 3.14f * (radius * radius);
                Console.WriteLine("Area of circle is {0}", area);
            }
        }

        public class Cylinder : IArea
        {
            float radius, height, area;
            public Cylinder(float r, float h)
            {
                radius = r;
                height = h;
                Console.WriteLine("Radius is {0} and height is {1}", radius, height);
            }

            public void findArea()
            {
                area = 3.14f * (radius * radius) * height;
                Console.WriteLine("Area of cylinder {0}", area);
            }
        }

        static void Main(string[] args)
        {
            Circle c = new Circle(10f);
            c.findArea();

            Cylinder cyl = new Cylinder(10f, 5f);
            cyl.findArea();

            Console.ReadKey();
        }
    }
}
