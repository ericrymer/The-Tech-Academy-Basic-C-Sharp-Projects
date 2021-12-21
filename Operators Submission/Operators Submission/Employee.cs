using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission
{
    //The class "Employee" is created, and inherit from the "Person" class
    public class Employee : Person
    {
        public int id { get; set; }

        //Overload the operator ==
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.id == employee2.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //When the "==" operator is overloaded, the "! =" Operator must also be overloaded.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.id != employee2.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}