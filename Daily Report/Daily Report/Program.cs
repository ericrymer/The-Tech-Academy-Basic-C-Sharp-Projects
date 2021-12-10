using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            //This will store variable "name"
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            //This will store variable "course"
            string course = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            //Value that entered is cast to int and the value is stored as "pageNumber"
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            //The value entered is cast to bool and the value is stored in the variable "needHelpWithAnything"
            bool needHelpWithAnything = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you\'d like to share? Please give specifics");
            //The value entered is stored in the variable "positiveExperiences"
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you\'d like to provide? Please be specific");
            //The value entered is stored in the variable "anyOtherFeedback"
            string anyOtherFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            //The value entered is cast to Int and the value is stored in the variable "hoursOfStudy"
            int hoursOfStudy = Convert.ToInt32(Console.ReadLine());
            //Print the message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            //Wait until I press the Enter key (this key is to enter a new line)
            Console.ReadLine();
            //End the program




        }
    }
}
