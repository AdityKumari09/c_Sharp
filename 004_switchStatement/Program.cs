using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_switchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCoffeeCost = 0;

        start:
            Console.Write("Please select your coffee size : 1. small, 2. medium, 3. large :- ");
            int userChoice = int.Parse(Console.ReadLine());

            switch(userChoice)
            {
                case 1:
                    totalCoffeeCost += 1;
                    break;
                case 2:
                    totalCoffeeCost += 2;
                    break;
                case 3:
                    totalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", userChoice);
                    goto start;
            }

            Console.Write("Do you want to buy another coffee - yes or no. :- " +
                "");
            string userDecision = Console.ReadLine();

            switch (userDecision.ToUpper())
            {
                case "YES":
                    goto start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid, please enter valid choice.", userDecision);
                    goto start;

            }

            Console.WriteLine("Thank you for shopping");
            Console.Write("Bill amount is {0} ", totalCoffeeCost);

        }
    }
}
