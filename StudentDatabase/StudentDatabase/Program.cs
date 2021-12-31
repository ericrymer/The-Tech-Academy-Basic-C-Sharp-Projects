using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new StudentDatabase())
            {
                var stud = new Student() { FirstName = "Eric", LastName = "Rymer" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.WriteLine("Student saved successfully!");

                foreach (var student in ctx.Students)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }
                Console.ReadLine();
            }
        }
    }
}