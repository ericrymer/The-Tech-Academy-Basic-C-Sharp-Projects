using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays are initialized with 7 values each
            string[] colorArray = { "Red", "Orange", "Yellow", "Green", "Cyan", "Blue", "Violet",};
            int[] numberArray = { 650, 600, 580, 550, 500, 450, 425, 400 };
            List<string> things = new List<string>();
            things.Add("Apple");
            things.Add("Orange");
            things.Add("Banana");
            things.Add("Grass");
            things.Add("Finch Eggs");
            things.Add("Ocean");
            things.Add("Plum");
            //The variable "exitLoop", will store the data entered by the user
            string exitLoop = "";
            int index = 0;

            //Print the instructions in the console
            Console.WriteLine("Console App Array Submission");
            Console.WriteLine("\nI have two arrangements that are associated with the colors of the rainbow. The first array is of the \"Colors\" while the second is their \"Wavelength\"");
            Console.WriteLine("\nAlso, there is a list of \"things\" associated with the color of each one.");
            do
            {
                //The data is requested, for finish the program the user must type "exit"
                Console.WriteLine("\nEnter the value of the index to display an element (0-6). NOTE: For the finish the program enter the word \"exit\"");
                exitLoop = Console.ReadLine();
                //In the next line, an attempt is made to pass the entered value to a numeric type
                if (int.TryParse(exitLoop, out index))
                {
                    //In case the data is a number, it is verified that area a number between in 0 and 6
                    if (index >= 0 && index <= 6)
                    {
                        //If it is true, it is printed the value in the position of the arrays
                        Console.WriteLine("\nThe value of the color in the position " + index + " is: " + colorArray[index]);
                        Console.WriteLine("\nThe wavelength of the color in position " + index + " is: " + numberArray[index] +" nm");
                        Console.WriteLine("\nSomething that is the same color as the value in position  " + index + ", is: " + things[index]);
                    }
                    else
                    {
                        //If it is false, it is printed a message
                        Console.WriteLine("The number doesn’t exist");
                    }
                }
                //If the data entered is not a number, the program print in the console the message
                else
                {
                    Console.WriteLine("The number is not valid");
                }
                //The loop ends when the user type a word "exit"
            } while (!exitLoop.ToUpper().Equals("EXIT"));
        }
    }
}
