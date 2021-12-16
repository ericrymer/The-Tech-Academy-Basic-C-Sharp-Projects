using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Strings_and_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers
            List<int> numbers = new List<int>() { 40, 90, 65, 56, 1008, 32, 72, 8650 };
            try
            {
                Console.WriteLine("Type in a whole number to divide the numbers on the list.");
                //Whole numbers only
                int number = Convert.ToInt32(Console.ReadLine());
                foreach (int auxNumber in numbers)
                {
                    //Print the results on the console
                    Console.WriteLine("The number " + auxNumber + " divided by " + number + " is equal " + (auxNumber / number));
                }
            }
            //If a whole number is not entered
            catch (FormatException ex)
            {
                Console.WriteLine("Please a whole number");
            }
            //If 0 is entered.
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            //Catches any other exceptions
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}