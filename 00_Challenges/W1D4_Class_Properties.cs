using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    // classes go in namespaces
    // Create a User class
    //Give the user a FirstName, LastName, ID(an integer, with no setter), and BirthDate properties.
    //Create a blank constructor and a full constructor for this class.
    //Bonus: Create a method that returns the full name of the user.
    //Double Bonus: Create a method that returns the age of the user in years.

    [TestClass]
    public class User
    {
        public User() { }
        public User(string firstName, string lastName, int iD, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
            BirthDate = birthDate;

        }
       

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public DateTime BirthDate { get; set; }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - BirthDate;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOld = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOld;
            }
        }
        [TestMethod]
        public void UserPropertiesTest()
        {

            User firstUser = new User();
            firstUser.FirstName = "Samuel";
            firstUser.LastName = "Perry";
            firstUser.ID = 1719;
            firstUser.BirthDate = new DateTime(1989, 02, 18);

            Console.WriteLine(firstUser.FirstName);
            Console.WriteLine(firstUser.LastName);
            Console.WriteLine(firstUser.ID);
            Console.WriteLine(firstUser.BirthDate);
            Console.WriteLine(firstUser.Age);
            Console.WriteLine(firstUser.FullName);
            User myDog = new User("Tobias", "Fünke", 69420, new DateTime(2018, 01, 01));
            Console.WriteLine(myDog.FullName);
            Console.WriteLine(myDog.ID);
            Console.WriteLine(myDog.BirthDate);

        }
    }
}
