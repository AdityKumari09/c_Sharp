using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_encapsulation
{
    internal class Program
    {
        public class Student
        {
            private int _id;
            private string _name;
            private int _passmarks = 35;
            public string _city { get; set; } //It automatically creates a private variable + getter + setter
            public string _email { get; set; }

            public int Passmark
            {
                get
                {
                    return this._passmarks;
                }
            }

            public string Name 
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("No name");
                    }

                    this._name = value; // these are the values set by the object will get passed over here
                }
                get
                {
                    return string.IsNullOrEmpty(this._name) ? "NO name" : this._name;
                }
            }

            public int Id
            {
                set
                {
                    if (value <= 0)
                    {
                        throw new Exception("Student Id cannot be negative");
                    }
                    this._id = value;
                }
                get
                {
                    return this._id;
                }
            }
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Id = 101;
            s1.Name = "Adity";
            s1._city = "Muzaffarpur";
            s1._email = "adity@gmail.com";

            Console.WriteLine("Student Id = {0}", s1.Id);
            Console.WriteLine("Student Name = {0}", s1.Name);
            Console.WriteLine("Passmark = {0}", s1.Passmark);
            Console.WriteLine("City = {0}", s1._city);
        }
    }
}
