using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print Header
            Console.WriteLine("Anonymous Income Comparison Program");
            //Program request for Person 1
            Console.WriteLine("Person 1");
            //Hourly Rate for Person 1
            Console.WriteLine("Hourly Rate");
            //Cast the enter value to decimal type
            decimal person1_HourlyRate = Convert.ToDecimal(Console.ReadLine());
            //Hours worked by person 1
            Console.WriteLine("Hours worked per week");
            int person1_HoursPerWeek = Convert.ToInt32(Console.ReadLine());
            //Calculate annual salary for Person 1
            decimal person1_AnnualSalary = (person1_HourlyRate * person1_HoursPerWeek) * 52;

            //Program request for Person 2
            Console.WriteLine("Person 2");
            //Hourly Rate for Person 2
            Console.WriteLine("Hourly Rate");
            //Cast the enter value to decimal type
            decimal person2_HourlyRate = Convert.ToDecimal(Console.ReadLine());
            //Hours worked by person 2
            Console.WriteLine("Hours worked per week");
            int person2_HoursPerWeek = Convert.ToInt32(Console.ReadLine());
            //Calculate annual salary for Person 2
            decimal person2_AnnualSalary = (person2_HourlyRate * person2_HoursPerWeek) * 52;

            //Print in console annual salarys for both Person 1 and 2.
            Console.WriteLine("Annual salary of Person 1: " + person1_AnnualSalary.ToString());
            Console.WriteLine("Annual salary of Person 2: " + person2_AnnualSalary.ToString());

            //Calculate if person 1 makes more than person 2, print the result in the console. 
            Console.WriteLine("Does Person 1 make more money than Person 2? " + (person1_AnnualSalary > person2_AnnualSalary).ToString());
            Console.ReadLine();

        }
    }
}
