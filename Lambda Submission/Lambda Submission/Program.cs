using System;
using System.Collections.Generic;


namespace Lambda_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of 10 employees are created
            List<Employee> employees = new List<Employee>()
            {
                new Employee { id = 1, FirstName = "Tony", LastName = "Stark"},
                new Employee { id = 2, FirstName = "Steve", LastName = "Rogers" },
                new Employee { id = 3, FirstName = "Bruce", LastName = "Banner" },
                new Employee { id = 4, FirstName = "Clint", LastName = "Barton" },
                new Employee { id = 5, FirstName = "Natasha", LastName = "Romanoff" },
                new Employee { id = 6, FirstName = "Joe", LastName = "Chill" },
                new Employee { id = 7, FirstName = "Peter", LastName = "Parker" },
                new Employee { id = 8, FirstName = "Thor", LastName = "Odinson" },
                new Employee { id = 9, FirstName = "Joe", LastName = "Smith" },
                new Employee { id = 10, FirstName = "Carol", LastName = "Danvers" },
            };

            List<Employee> newEmployees = new List<Employee>();
            foreach (Employee auxEmployee in employees)
            {
                if (auxEmployee.FirstName.Equals("Tony"))
                {
                    newEmployees.Add(auxEmployee);
                }
            }
            Console.WriteLine("List Avengers");
            PrintOnTheConsole(newEmployees);

            List<Employee> newEmployeesLambda = employees.FindAll(x => x.FirstName.Equals("Joe"));
            //Print the items of the list "List Joe" on the console
            Console.WriteLine("\nList Joe");
            PrintOnTheConsole(newEmployeesLambda);

            //Using a lambda expression, a list is created with the employees with the id greather than 5, from the list employees
            List<Employee> newEmployeesLambda2 = employees.FindAll(x => x.id > 5);
            //Print the items of the list "newEmployeesLambda2" on the console
            Console.WriteLine("\nList Others");
            PrintOnTheConsole(newEmployeesLambda2);

            Console.ReadLine();
        }
        //Method for print on the console the items of a list of employees
        public static void PrintOnTheConsole(List<Employee> listEmployees)
        {
            foreach (Employee auxE in listEmployees)
            {
                Console.WriteLine("id = |" + auxE.id + "|\tFirstName = |" + auxE.FirstName + "|\t\tLastName = |" + auxE.LastName + "|");
            }
        }
    }
}
  