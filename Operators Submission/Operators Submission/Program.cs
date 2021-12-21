using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee 1 is created
            Employee employee1 = new Employee();
            employee1.id = 1;
            employee1.FirstName = "Eric";

            //Employee 2 is created
            Employee employee2 = new Employee();
            employee2.id = 1;
            employee1.FirstName = "Jeff";

            //Print result of the ID comparison in console
            if(employee1 == employee2)
            {
                Console.WriteLine("The ID of Employee " + employee1.FirstName + " is equal to that employee " + employee2.FirstName);
            }
            else
            {
                Console.WriteLine("The ID of Employee " + employee1.FirstName + " is not equal to that employee " + employee2.FirstName);
            }

            //Change the "id" in employee2
            employee2.id = 2;

            //Print the result of the ID comparison on the console
            if (employee1 == employee2)
            {
                Console.WriteLine("The ID of Employee " + employee1.FirstName + " is equal to that employee " + employee2.FirstName);
            }
            else
            {
                Console.WriteLine("The ID of Employee " + employee1.FirstName + " is not equal to that employee " + employee2.FirstName);
            }

            Console.ReadLine();
        }
    }
}
