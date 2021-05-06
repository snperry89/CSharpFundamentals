using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public class User
    {
        // Blank Constructor
        public User() { }

        // Full Constructor (blueprint)
        public User(string first, string last, int id, DateTime doB)
        {
            FirstName = first;
            LastName = last;
            Id = id;
            DoB = doB;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public DateTime DoB { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";

        }
    }
}
