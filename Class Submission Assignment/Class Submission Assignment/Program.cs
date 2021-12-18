using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // class ClassOps is instantiated
                ClassOps classOps = new ClassOps();

                //Ask user to enter a number
                Console.WriteLine("Please enter a whole number");

                //int number
                string number = Console.ReadLine();
                //For the class ClassOps 
                int numB = 0; 
                //For the class ClassOpsStatic
                int numC = 0;
                //Stores result in the variable "numB"
                classOps.Divide(number, out numB);

                ClassOpsStatic.Divide(number, out numC);

                Console.WriteLine("\nResult of the class \"ClassOps\"");
                if (numB == -1)
                {
                    //Will be shown if number cannot be divided by 2.
                    Console.WriteLine("The number " + number + " cannot be divided by 2");
                }
                else
                {
                    //If sucessful print below
                    Console.WriteLine("The number " + number + " divided by 2 is equal to " + numB);
                }

                
                Console.WriteLine("\nResult of the static class \"ClassOpsStatic\"");
                if (numC == -1)
                {
                    //Will be shown if number cannot be divided by 2.
                    Console.WriteLine("The number " + number + " cannot be divided by 2");
                }
                else
                {
                    //If sucessful print below
                    Console.WriteLine("The number " + number + " divided by 2 is equal to " + numC);
                }
            }
            //If exist an exception, is catched and print the error message on the console
            catch (Exception e)
            {
                Console.WriteLine("Error -> " + e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

                

                
