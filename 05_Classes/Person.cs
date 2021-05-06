using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Person
    {
        public Person() { }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; set; }

        // Backing field (hidden property, private variable)
        private string _lastname;
        public string LastName
        {
            get
            {
                // returns the information from the _lastName property
                return _lastname;
            }
            set
            {
                //value comes form LastName, sets private field _lastName as LastName
                _lastname = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        // when you do math with type DateTime: it becomes type TimeSpan
        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOld = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOld;

            }
        }
        public DateTime DateOfBirth { get; set; }

        // Using a class as a type
        public Vehicle Transport { get; set; }

    }
}
