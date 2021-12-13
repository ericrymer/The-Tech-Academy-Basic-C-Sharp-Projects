using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are some examples of a \"While\" Statement and \"Do While\" Statement");
            //variable "number" is set to 10
            int number = 10;
      
            Console.WriteLine("\n\"While Statement\"");
            //For the finish the loop, the value of the number must be greater than 10
            while (number <= 10)
            {
                Console.WriteLine("\nFor finish this loop enter a number greater than 10");
                number = Convert.ToInt32(Console.ReadLine());
            }
            //the loop is finished
            Console.WriteLine("\nLoop of the \"While Statement\" are finished");
            Console.WriteLine("\n\"Do While Statement\"");
            //enters the loop without performing a variable condition
            do
            {
                Console.WriteLine("For finish this loop enter a number less than 10");
                number = Convert.ToInt32(Console.ReadLine());
            }
            //the loop finish, when the number is less than 10
            while (number >= 10);
            Console.WriteLine("Loop of the \"Do While Statement\" are finished");
            Console.ReadLine();
        }
    }
}
