using System;
using System.Collections.Generic;
using System.Text;

namespace Module2
{
    public abstract class Person 
    {
        public int personID { get; set; }
        public string TaxID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }

        public string getAge()
        {
            return FirstName + " is " + (DateTime.Now.Year - Birthday.Year).ToString();
        }

        public string goodBye()
        {
            Console.WriteLine("Exiting System");
            Environment.Exit(0);
            return "GoodBye";
        }
    }

    public abstract class Employee : Person
    {
        public DateTime StartDate;
        public DateTime EndDate;
    }

    public sealed class FacultyMember : Employee, IPerson
    {
        public Person ChairPerson;

        public override string ToString()
        {
            return LastName + " is a faculty member";
        }

        void IPerson.createPerson(string lastName, DateTime startDate)
        {
            throw new NotImplementedException();
        }
    }
}
