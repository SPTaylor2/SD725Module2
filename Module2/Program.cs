using Module2;
using Module2.Models;
using System;
using System.Reflection;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            string consoleInput;
            FacultyMember newFacultyMember = new FacultyMember();

            newFacultyMember.personID = 100;
            newFacultyMember.LastName = "Garcia";
            newFacultyMember.FirstName = "Juan";
            newFacultyMember.Birthday = new DateTime(1979, 7, 1);
            newFacultyMember.StartDate = new DateTime(2019, 7, 1);
            Console.WriteLine("Inhteritance and inheritance models Example");
            
            Console.WriteLine(newFacultyMember.ToString());

            FacultyMember anotherNewFacultyMember = new FacultyMember();
            anotherNewFacultyMember.LastName = "Marks";
            anotherNewFacultyMember.FirstName = "Eleanor";

            FacultyMember thirdNewFacMember = new FacultyMember();
            thirdNewFacMember.FirstName = "Anna";
            thirdNewFacMember.LastName = "Patel";

            FacultyMember[] allFaculty = new FacultyMember[3]
            {
                newFacultyMember,
                anotherNewFacultyMember,
                newFacultyMember,
            };

            Console.WriteLine("--------------------");
            Console.WriteLine("IEnumberable Example");
            Faculty peopleList = new Faculty(allFaculty);
            foreach (Person p in peopleList)
                Console.WriteLine(p.FirstName + " " + p.LastName);

            Console.WriteLine("--------------------");
            Console.WriteLine("Reflection Example");
            Type thisType = newFacultyMember.GetType();
            Console.WriteLine("Valid Commands are ToString, getAge, goodBye");

            do
            {
                Console.Write("Enter a command==> ");
                consoleInput = Console.ReadLine();
                MethodInfo commandMethod = thisType.GetMethod(consoleInput);

                if (commandMethod == null)
                {
                    Console.WriteLine("This is not a valid commend.  Commands are case sensitive.");
                }
                else
                {
                    Console.WriteLine(commandMethod.Invoke(newFacultyMember, null));
                }

            } while (true);

        }
    }
}
