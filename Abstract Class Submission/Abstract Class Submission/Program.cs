using System;

namespace Abstract_Class_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee object instantiated with First Name = Sample, Last Name = Student
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Calls SayName method
            employee.SayName();
            Console.ReadLine();
        }
    }
}
