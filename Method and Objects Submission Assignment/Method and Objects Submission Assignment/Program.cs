using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_and_Objects_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and initialize an Employee object 
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Calls superclass method SayName() on the Employee Object.
            employee.SayName();
            Console.ReadLine();
        }
    }
}
