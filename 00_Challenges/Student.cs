using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public enum ClassTaking { CyberSecurity, WebDevelopment, SoftwareDevelopment }
    public enum TypeOfBadge { White, Gold, Red, Blue }

    // Make a Student class
    public class Student

    // that has the following properties
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ClassTaking TakingClass { get; set; }
        public TypeOfBadge BadgeType { get; set; }
        public decimal BalanceOwed { get; set; }

        public bool HasGraduated { get; set; }
        // Make an empty constructor
        public Student() { }
        // Make an overloaded constructor
        public Student(string first, string last, DateTime dob, ClassTaking course, decimal balance, TypeOfBadge badge, bool hasGraduated)
        {
            FirstName = first;
            LastName = last;
            DateOfBirth = dob;
            TakingClass = course;
            BalanceOwed = balance;
            BadgeType = badge;
            HasGraduated = hasGraduated;


        }
    }
    // Make an instructor class
    public class Instructor
    {
        public Instructor(int employeeNumber)
        {
            EmployeeNumber = employeeNumber;
            Console.WriteLine("Hello new employee");
        }
        public Instructor(string firstName, string lastName, DateTime dob, ClassTaking course, int employeeNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            TakingClass = course;
            EmployeeNumber = employeeNumber;

        }


        // with the following properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int EmployeeNumber { get; set; }
        public ClassTaking TakingClass { get; set; }
    }
}

