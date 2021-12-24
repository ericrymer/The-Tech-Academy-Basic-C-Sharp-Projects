using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a cons string named "courseName"
            const string courseName = "Software Developer Course";

            //Create List with var
            var courseList = new List<Courses>()
            {
                new Courses(courseName),
                new Courses(courseName, "HTML and CSS", "Version Control", 1),
                new Courses(courseName, "DataBase SQL", "Python", 26),
                new Courses(courseName,"C# and .NET", "Visual Studio", 50),
            };

            //Print courses in console
            foreach (Courses course in courseList)
            {
                Console.WriteLine(course.ToString());
            }
            Console.ReadLine();
        }

        //Courses class created
        public class Courses
        {
            //Default string if nothing is added to list above
            public Courses(string course) : this(course, "Basic Programming Terms", "Course Overview", 1)
            {
            }

            //Adding another contructor
            public Courses(string course, string section, string subsection, int step)
            {
                Course = course;
                Section = section;
                Subsection = subsection;
                Step = step;
            }

            //Course Properties
            public string Course;
            public string Section;
            public string Subsection;
            public int Step;

            //Override String Method to populate string.
            public override string ToString()
            {
                return string.Format("You are studying the {0} course, section {1}, subsection {2}, step {3}", Course, Section, Subsection, Step);
            }
        }
    }
}
