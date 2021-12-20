using System;


namespace Method_Class_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //MathOperation class is instantiated
            MathOperation mathOperation = new MathOperation();
            //For purpose of this exercise, the variables numA and numB are created
            int numA = 15, numB = 3;
            //Call the method in the class, passing in two numbers
            mathOperation.Multiplication(56, 23);
            //Call the method "Multiplication" with the two parameters, specifying the parameters by name
            mathOperation.Multiplication(numA: numA, numB: numB);
            Console.ReadLine();
        }
    }
}