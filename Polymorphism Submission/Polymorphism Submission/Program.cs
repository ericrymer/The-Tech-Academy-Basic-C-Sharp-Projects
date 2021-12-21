using System;

namespace Polymorphism_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Employee
            IQuittable employee = new Employee();
            employee.Quit();
            Console.ReadLine();
        }
    }
}
