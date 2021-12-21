using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Submission
{
    //Abstract Class Person is created
    public abstract class Person
    {
        //Two String Properties "First Name" and "Last Name"
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
