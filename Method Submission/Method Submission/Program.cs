using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //MathOperation class is instantiated
                MathOperation mathOperation = new MathOperation();
                //User is asked to enter a whole number
                Console.WriteLine("Please, enter a whole number");
                //Data entered will be stored in variable "numA"
                int numA = Convert.ToInt32(Console.ReadLine());
                //User is asked to enter a second number
                Console.WriteLine("Please enter a 2nd whole number, if you don't want to enter a number, press the enter key");
                //Data entered is stored within the variable "auxNumberB"
                string auxNumberB = Console.ReadLine();
                //The variable "numB" will store the valid number typed by the user
                int numB;
                //Try parising the value of auxNumberB to int
                if (!int.TryParse(auxNumberB, out numB))
                {
                    if(auxNumberB.Length > 0)
                    {
                        throw new FormatException("If you don\'t want to write the second whole number, please press the enter key;" +
                            " you entered another data that cannot be converted to integer");
                    }
                    else
                    {
                       Console.WriteLine("\nThe mathematical operation " + numA + " * 4 = " + mathOperation.Multiplication(numA));
                    }
                }
                else
                {
                    Console.WriteLine("\nThe mathematical operation " + numA + " * " + numB + " = " + mathOperation.Multiplication(numA, numB));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nError!!!! -> " + e.Message);
            }
            finally
            {
                //Wait until the user press the enter key
                Console.ReadLine();
            }
        }
    }
}