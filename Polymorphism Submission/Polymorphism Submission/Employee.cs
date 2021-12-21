using System;

namespace Polymorphism_Submission
{
    //Employee class is created, and inherits from Person Class
    public class Employee : Person, IQuittable
    {
        //Implementation of IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Method Quit()");
        }
    }
}
