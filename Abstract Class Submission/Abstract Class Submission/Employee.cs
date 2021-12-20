using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Submission
{
    //Employee Class is created, and inherits from the Person Class
    class Employee : Person
    { 
        //Virtual Method of Person Class is implemented in the Employee Class
        public override void SayName()
        {
            base.SayName();
        }
    }
}
