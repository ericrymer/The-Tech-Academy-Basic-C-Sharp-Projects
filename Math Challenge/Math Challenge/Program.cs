using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //math formuals
            int sum = num1 + num2;
            int subtraction = num1 - num2;
            int multiplication = num1 * num2;
            int division = num1 / num2;

            //Will write out formalas.
            Console.WriteLine("Addition");
            Console.WriteLine(num1.ToString() + " + " + num2.ToString() + " = " + sum.ToString());
            Console.WriteLine("Subtraction");
            Console.WriteLine(num1.ToString() + " - " + num2.ToString() + " = " + subtraction.ToString());
            Console.WriteLine("Multiply");
            Console.WriteLine(num1.ToString() + " * " + num2.ToString() + " = " + multiplication.ToString());
            Console.WriteLine("Divide");
            Console.WriteLine(num1.ToString() + " / " + num2.ToString() + " = " + division.ToString());

            Console.WriteLine("Isn't math fun?");
            Console.ReadLine();
        }
    }
}
