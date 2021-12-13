using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car Insurance Name
            Console.WriteLine("Welcome to Rymer Car Insurance ");
            Console.WriteLine("\nPlease answer the questions below to see if you qualify for insurance");

            //Ask's the user what is their age
            Console.WriteLine("\nWhat is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            //Ask's the user if they have ever had an DUI
            Console.WriteLine("\nHave you ever had a DUI? (true or false)");
            //Store value as "HaveDui"
            bool HaveDui = Convert.ToBoolean(Console.ReadLine());
            //Ask's the user how many speeding tickets they have
            Console.WriteLine("\nHow many speeding tickets do you have?");
            //Store value of speeding tickets as "SpeedingTickets"
            int SpeedingTickets = Convert.ToInt32(Console.ReadLine());

            //Qualifications for values above
            Console.WriteLine("\nApplicant qualifes for car insurance?");
            //print the results in the console with the following rules
            //a. applicants must be over 15 years old.
            //b. applicants must not have any dui’s.
            //c. applicants must not have more than 3 speeding tickets
            Console.WriteLine(age > 15 && HaveDui == false && SpeedingTickets <= 2);
            Console.ReadLine();
        }
    }
}
