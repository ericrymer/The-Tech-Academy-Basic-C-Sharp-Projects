using System;


namespace Abstract_Class_Submission
{
    //Abstract Class Person is created
    public abstract class Person
    {
        //Adds two string properties First Name and Last Name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Virtual Method SayName is created
        public virtual void SayName()
        {
            //Print full name on console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
