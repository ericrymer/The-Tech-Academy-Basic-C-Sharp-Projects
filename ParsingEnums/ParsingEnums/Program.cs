using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = default;
            DaysOfWeek daysOfWeek;
            string dowValue = "";
            do
            {
                try
                {
                    //Prompts user to enter a day/number
                    Console.WriteLine("Please Enter either a day or number 0-6");
                    //Store the data in the variable "dowValue"
                    dowValue = Console.ReadLine();
                    //Try parse "value" to enum DaysOfWeek
                    if (Enum.TryParse(dowValue, true, out daysOfWeek))
                    {
                        //This will check valid day 0-6
                        int day;
                        if (Int32.TryParse(dowValue, out day))
                        {
                            if (day >= 0 && day <= 6)
                            {
                                //If number is entered
                                Console.WriteLine("The day entered is valid.");
                                if ((int)new DateTime().DayOfWeek == day)
                                    //If current day of the week.
                                    Console.WriteLine("This is the current day of the week.");
                                else
                                    //If not, throw its own exception
                                    throw new NotDayException("It is not the current day of the week");
                            }
                            else
                            {
                                //If valid number is not entered
                                throw new Exception("Please enter a valid number for the week.");
                            }
                        }
                        else
                        {
                            //If day is entered
                            Console.WriteLine("The day entered is valid.");
                            if ((int)new DateTime().DayOfWeek == (int)daysOfWeek)
                                //If it is the current day of the week, show the next message on the console
                                Console.WriteLine("This is the current day of the week.");
                            else
                                //If not, throw its own exception
                                throw new NotDayException("It is not the current day of the week");
                        }
                    }
                    else
                    {
                        //If entry entered is not a valid date
                        throw new Exception("Please, enter a valid day for the day of the week.");
                    }
                }
                //Catch any exceptions
                catch (NotDayException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: -> " + e.Message);
                }
            } while (!dowValue.ToUpper().Contains("EXIT")); //
        }

        //Days of the week
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}