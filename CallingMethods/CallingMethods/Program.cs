using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            //Requests user to enter a number
            Console.WriteLine("Please enter a number");
            //Data is stored in the variable number
            int number = int.Parse(Console.ReadLine());
            //Class Operations 
            MathOperations mathOperations = new MathOperations();
            //"Addition"
            Console.WriteLine("The number " + mathOperations.secondnumber + " + " + number + " is equal to " + mathOperations.Addition(number));
            //Subtraction
            Console.WriteLine("The number " + mathOperations.secondnumber + " - " + number + " is equal to " + mathOperations.Subtraction(number));
            //Multiplication
            Console.WriteLine("The number " + mathOperations.secondnumber + " * " + number + " is equal to " + mathOperations.Multiplication(number));
            //Division
            Console.WriteLine("The number " + mathOperations.secondnumber + " / " + number + " is equal to " + mathOperations.Division(number));
        }
            //If there is any exception, catch that exception
            catch (Exception e)
            {
                //print a message error with the exception on the console
                Console.WriteLine("Error !!!! -> " + e.Message);
            }
            finally
            {
                //wait until user press enter key
                Console.ReadLine();
            }
        }
    }
}