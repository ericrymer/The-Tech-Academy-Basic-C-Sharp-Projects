using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission
{
    //The abstract class "Person" is created
    public abstract class Person
    {
        //Add two string properties "FirstName" and "LastName"
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //The virtual method "SayName" is created
        public virtual void SayName()
        {
            //Print the full name on the console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}