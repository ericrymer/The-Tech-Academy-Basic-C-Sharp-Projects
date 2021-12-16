using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
         
            int numIterations = 1;
            
            while (option != 5 && numIterations <= 8)
            {
                //Print the menu
                Console.WriteLine("\n\nHello, Please select an option below");
                Console.WriteLine("\n1. Add to a sentence");
                Console.WriteLine("2. Find the text within the array.");
                Console.WriteLine("3. Find two items within a list.");
                Console.WriteLine("4. Find repeating strings in a list.");
                Console.WriteLine("5. EXIT.");
                Console.Write("\nPlease, select an option (1-3): ");
                //The value entered will be stored in "option"
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            //Calls option 1
                            AddSentence();
                            break;
                        case 2:
                            //Calls option 2
                            FindValue();
                            break;
                        case 3:
                            //Calls option 3
                            FindDupInTheList();
                            break;
                        case 4:
                            //Calls option 4
                            RepeatsList();
                            break;
                        case 5:
                            break;
                        default:
                            //Print an error message on the console
                            Console.WriteLine("The option you have chosen is not valid, please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("The option you have chosen is not valid, please try again.");
                }
                numIterations++;
            }
        }

        public static void AddSentence()
        {
            //Array with names
            string[] names = { "John", "David", "Mary", "Sue", "Parker", "Nigel", "Mark", "Steve" };
            string sentence = "";

            //The next instruction return the menu when the user typed "menu"
            while (!sentence.ToUpper().Equals("MENU"))
            {
                Console.WriteLine("\n\nYou've chosen option 1, please enter a phrase or word to add create a sentence.");
                Console.WriteLine("NOTE: to return to the menu, type \"menu\"");
                //The entered value is stored in the "sentence" variable
                sentence = Console.ReadLine();
                for (int index = 0; index < names.Length; index++)
                {
                    //This concats values with entered word/phrase
                    names[index] = string.Concat(names[index], " ", sentence);
                }
                for (int index = 0; index < names.Length; index++)
                {
                    //Prints names with concat values
                    Console.WriteLine(names[index]);
                }
            }
        }

        //Find a value within the array
        public static void FindValue()
        {
            //List with colors, none is repeated
            List<string> colors = new List<string>() { "Red", "Orange", "Yellow", "Green", "Indigo", "Violet", "Cyan", "Black" };
            //Finish Option and return to menu
            bool finish = false;
            //stored variable
            string colorEntered = "";
            while (!colorEntered.ToUpper().Equals("MENU"))
            {
                Console.WriteLine("\n\nYou've selected Option 2, Please enter a color to see if it made the list.");
                Console.WriteLine("PLEASE NOTE: To complete the program, you must find the correct answer");
                //Store the value in the variable "colorEntered"
                colorEntered = Console.ReadLine();
                for (int index = 0; index < colors.Count; index++)
                {
                    if (colors[index].ToUpper().Equals(colorEntered.ToUpper()))
                    {
                        //if entered a correct color, print below
                        Console.WriteLine("Congratulations you found the color!!!! Is in the index " + index);
                        //This finishes the program, since true, this will take you back to the main menu.
                        finish = true;
                        break;
                    }
                }
                if (!finish)
                {
                    //if incorrect, print below.
                    Console.WriteLine("Sorry, that color was not found");
                }
            }
        }

        //Find duplicates in list
        public static void FindDupInTheList()
        {
            //List a colors
            List<string> colors = new List<string>() { "Red", "Orange", "Yellow", "Blue", "Green", "Red", "Magenta", "Yellow" };
            //In the varibale "indices", the indices that were found will be stored
            List<int> indices = new List<int>();
            //Flag that finish the procedure and return to menu
            bool finish = false;
            //this variable will store the value typed by the user
            string colorEntered = "";
            while (!finish)
            {
                Console.WriteLine("\n\nYou've selected option 3, Please find the duplicates within the list *Hint: Colors");
                Console.WriteLine("PLEASE NOTE: To complete the program, you must find the correct answer.");
                //Store the value in the variable "colorEntered"
                colorEntered = Console.ReadLine();
                for (int index = 0; index < colors.Count; index++)
                {
                    //if color is in the list
                    if (colors[index].ToUpper().Equals(colorEntered.ToUpper()))
                    {
                        //the index of the color entered is added to the list
                        indices.Add(index);
                    }
                }
                //If color was found 2 times
                if (indices.Count == 2)
                {
                    //Prints the following
                    Console.Write("Congratulations! you found the color!!!! Is is located in the array at spots ");
                    foreach (int i in indices)
                    {
                        Console.Write(i + "  ");
                    }
                    finish = true;
                }
                //if the color was only in the array once.
                else if (indices.Count == 1)
                {
                    //If color entered was found, but was only found once.
                    Console.WriteLine("Sorry! This color was not found in our list more than once, however it is located in " + indices[0]);
                    //Clears list
                    indices.Clear();
                }
                //If color was not found
                else
                {
                    //Prints message if not found
                    Console.WriteLine("Sorry, try again");
                    //Clears list
                    indices.Clear();
                }
            }
        }

        //This will find any duplicates in the list
        //Return to menu automatically.
        public static void RepeatsList()
        {
            //A list with indistinct values is created
            List<string> words = new List<string>() { "red", "white", "gold", "moose", "red", "flash", "yellow", "tree", "bike", "gold", "moose" };
            //Another list is created, in that list the items of the first list will be copied
            List<string> dupWords = new List<string>();
            //the items from the "words" list are copied to "dupWords" list
            words.ForEach(w => dupWords.Add(w));
            //A list will be created of the repeated words will be stored
            List<int> itemsInList = new List<int>();
            while (words.Count > 0)
            {
                //The variable itemsInList is clear
                itemsInList.Clear();
                
                string word = words[0];
                //That word is searched in the list dupWords 
                for (int i = 0; i < dupWords.Count; i++)
                {
                    if (word.ToUpper().Equals(dupWords[i].ToUpper()))
                    {
                        //If exist, then store in the itemsInList
                        itemsInList.Add(i);
                    }
                }
                //If the word is entered more than once, it will not be repeated.
                if (itemsInList.Count <= 1)
                {
                    Console.WriteLine("The word " + word + " is not repeated");
                }
                //if not
                else
                {
                    //Print on the console
                    Console.Write("The word " + word + " is repeated in the items:");
                    foreach (int item in itemsInList)
                    {
                        Console.Write("\t" + item);
                    }
                    Console.Write("\n");
                }
                //Words that have been entered will be removed.
                words.RemoveAll(w => w.Equals(word));
            }
        }
    }
}