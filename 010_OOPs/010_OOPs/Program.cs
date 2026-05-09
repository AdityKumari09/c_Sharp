using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_OOPs
{
    internal class Program
    {
        public class trainee
        {
            //static variable
            public static int ID = 800001;

            public int _traineeId;
            public string _traineeName;
            public int _score;
            public string _result;

            //constructor
            public trainee()
            {
                _traineeId = ID;
                //increment the id value for the next trainee
                ID++;
                _traineeName = " ";
                _score = 0;
                _result = "fail";
            }

            public void getEmployeeDetails(string name, int score)
            {
                _traineeName = name;
                _score = score;
                _result = (_score >= 7) ? "pass" : "fail"; 
            }

            public void displayEmployeeDetails()
            {
                Console.Write("Employee id :- " + _traineeId + "\t");
                Console.Write("Employee name :- " + _traineeName + "\t");
                Console.Write("Employee score :- " + _score + "\t");
                Console.WriteLine("Employee result :- " + _result);
            }
        }
        static void Main(string[] args)
        {
            trainee t1 = new trainee();
            t1.getEmployeeDetails(" ", 1);

            trainee t2 = new trainee();
            t2.getEmployeeDetails("Adity", 8);

            trainee t3 = new trainee();
            t3.getEmployeeDetails("Casio", 5);

            t1.displayEmployeeDetails();
            t2.displayEmployeeDetails();
            t3.displayEmployeeDetails();
        }
    }
}
