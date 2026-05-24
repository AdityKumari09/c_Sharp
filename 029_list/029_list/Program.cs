using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_list
{
    public class Customer
    {
        public int CustId{ get; set; }
        public string Name { get; set; }

        public string City { get; set; }
        public double Balance { get; set; }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>();

            Customer c1 = new Customer { CustId = 101, Name = "Scott", City = "Hyderabad", Balance = 25000};
            Customer c2 = new Customer { CustId = 102, Name = "David", City = "Delhi", Balance = 35000 };
            Customer c3 = new Customer { CustId = 103, Name = "Varun", City = "Goa", Balance = 28000 };
            Customer c4 = new Customer { CustId = 104, Name = "Neha", City = "Bihar", Balance = 50000 };

            Customers.Add(c1);
            Customers.Add(c2);
            Customers.Add(c3);
            Customers.Add(c4);

            foreach(Customer obj in Customers)
            {
                Console.WriteLine(obj);
                //Console.WriteLine(obj.CustId + " " + obj.Name + " " + obj.City + " " + obj.Balance);
            }

        }
    }
}
