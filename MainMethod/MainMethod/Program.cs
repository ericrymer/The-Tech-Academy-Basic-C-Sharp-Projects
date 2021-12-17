using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Class MathOperation is instantiated
                MathOperation mathOperation = new MathOperation();
                //Three variables were used for the example
                int numberA = 25;
                decimal numberB = 22.5678m;
                string numberC = "47";
                //First Method with an integer parameter
                Console.WriteLine(mathOperation.auxNumber + " + " + numberA + " = " + mathOperation.Addition(numberA));
                //Second Method with a decimal parameter
                Console.WriteLine(mathOperation.auxNumber + " + " + numberB + " = " + mathOperation.Addition(numberB));
                //Third method with a string parameter
                Console.WriteLine(mathOperation.auxNumber + " + " + numberC + " = " + mathOperation.Addition(numberC));
            }
            //Catch any exceptions if errors come up
            catch (Exception e)
            {
                Console.WriteLine("Error!!!! " + e.Message);
            }
            finally
            {
                //Wait until the user presses the enter key
                Console.ReadLine();
            }
        }
    }
}