using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmission
{
    class Program
    {
        static void Main(string[] args)
      
        {
            //prints "Welcome to Packege Express"
            Console.WriteLine("Welcome to Package Express");

            //Prompt user to enter package weight
            Console.WriteLine("\nPlease enter the Package Weight");
            int packageweight = Convert.ToInt32(Console.ReadLine());
            //If the weight of the package is moer than 50, print a message in the console and end the program
            if (packageweight > 50)
            {
                Console.WriteLine("\nError: Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            //else
            {
                //Package width
                Console.WriteLine("What is the width of the package?");
                int packagewidth = Convert.ToInt32(Console.ReadLine());
                //Package height
                Console.WriteLine("What is the height of the package?");
                int packageheight = Convert.ToInt32(Console.ReadLine());
                //Package length
                Console.WriteLine("What is the length of the package?");
                int packagelength = Convert.ToInt32(Console.ReadLine());
                //if total diamentions are greater than 50, print the message in the console and end program
                if ((packagewidth + packageheight + packagelength) > 50)
                {
                    Console.WriteLine("Sorry, but this package is too large to be shipped via Package Express");
                }
                //else
                else
                {
                    //Calcuate estimated total for shipping
                    decimal totalForShipping = ((packageweight * packageheight * packagelength) * packageweight) / 100;
                    //The "totalForShipping" variable was given a currency format with two decimals
                    Console.WriteLine("Your estimated total for shipping this package is: $" + string.Format("{0:0.00}", totalForShipping) + " USD");
                }

            }
            Console.ReadLine();
        }
    }
}
