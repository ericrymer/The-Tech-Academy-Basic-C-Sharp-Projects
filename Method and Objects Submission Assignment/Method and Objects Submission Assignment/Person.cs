using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_and_Objects_Submission_Assignment
{
    //Person Class is created
     public class Person
    {
        //Add two properties to class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Method "SayName" is created
        public void SayName()
        {
            //Prints full name on console
            Console.Write("Name: " + FirstName + " " + LastName);
        }

    }
}
