using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try/Catch for any exceptions
            try
            {
                //Current Time/Date is stored as "currentDateTime"
                DateTime currentDateTime = DateTime.Now;
                //Print "currentDateTime"
                Console.WriteLine("\nCurrent date and time: " + currentDateTime.ToString());
                //Ask the user a number
                Console.WriteLine("\nPlease enter a number");
                //Convert the data to integer
                int hours = Convert.ToInt32(Console.ReadLine());
                //Print on the console the value of variable "currentDateTime" plus the hours entered by the user
                Console.WriteLine("\nCurrent date and time plus " + hours + " hour(s) is equal to " + currentDateTime.AddHours(hours).ToString());
            }
            //Catch any exception
            catch (Exception e)
            {
                //Print the error on the console
                Console.WriteLine("Sorry, not a valid entry " + e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}