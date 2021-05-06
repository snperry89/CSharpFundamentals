using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_Challenges
{
    [TestClass]
    public class W1D3_Conditions_Loops
    {
        [TestMethod]
        public void Part1()
        //Print every letter of the word "Supercalifragilisticexpialidocious" to the console, one at a time.
        {
            string word = "Supercalifragilisticexpialidocious";
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }

        }
        [TestMethod]
        public void Part2()
        //Next, do the same, except only print the letter if it's an 'i'. If it's any other letter, print "Not an i".
        //Do the same for 'l"
        {
            string notAnI = "not an I";
            string orAnL = "or an L";
            string word = "Supercalifragilisticexpialidocious";
            foreach (char letter in word)
            {
                if (letter == 'i')
                {
                    Console.WriteLine('I');// could also put letter here
                }
                if (letter != 'i' && letter != 'l')
                {
                    Console.WriteLine(notAnI + " " + orAnL);
                }
                if (letter == 'l')
                {
                    Console.WriteLine('L');
                }

            }
        }
        [TestMethod]
        public void Part3()
        //After that, print the number of letters in the word (do this with code, not by counting manually and hard-coding the number).
        // Method 1- the easy way
        {
            string word = "Supercalifragilisticexpialidocious";
            Console.WriteLine(word.Length);

            // Method 2 - the long way
            int letterCount = 0;
            foreach (char letter in word)
            {
                ++letterCount;
                //letterCount += 1;
                //letterCount = letterCount +1;
            }
            Console.WriteLine(letterCount);
        }



        [TestMethod]
        public void Part4()
        //Declare and initialize variables that hold your first name, last name, and age
        {
            string firstName = "Samuel";
            string lastName = "Perry";
            int age = 32;

            Console.WriteLine(firstName + " " + lastName + " is" + " " + age + " years old.");
        }

        [TestMethod]
        public void Part5()
        //Declare and initialize an array that holds a collection of at least four of your favorite book or movie titles
        {
            string[] books = { "Neuromancer", "A Song of Ice and Fire", "The Dark Tower", "Brave New World" };
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
        }

        [TestMethod]
        public void Part6()
        //Make a list to hold dates. Include on that list the current date and time.
        {
            List<DateTime> dates = new List<DateTime>();

            dates.Add(DateTime.Now);
            dates.Add(new DateTime(1989, 02, 18));
            dates.Add(new DateTime(1990, 12, 07));
            foreach (DateTime date in dates)
            {
                Console.WriteLine(date);
            }
        }
        [TestMethod]
        public void Part7()
        //Write out to the Console the values calculated by your age variable and the number 7.
        {
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1989, 02, 18);
            TimeSpan ageTime = today - birthday;
            int ageInDays = ageTime.Days;
            int age = ageInDays / 365;
            int var = 7;
            int sum = age + var;
            int diff = age - var;
            int prod = age * var;
            int quot = age / var;
            int rem = age % var;
            Console.WriteLine("age = " + age);
            Console.WriteLine("variable = " + var);
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("difference = " + diff);
            Console.WriteLine("product = " + prod);
            Console.WriteLine("quotient = " + quot);
            Console.WriteLine("remainder = " + rem);

        }

        [TestMethod]
        public void Part8()
        //Write out a collection of conditionals that evaluates a new variable for how many hours of sleep the user gets.
        //You can just initialize this variable for now, it does not have to be actually given by a user.
        //If the hours slept is greater or equal to 10, write to the console "Wow that's a lot of sleep!"
        //If the hours is greater than 8 but less than 10, write to the console "You should be pretty rested"
        //If the hours is greater than 4 but less than 8, output "Bummer"
        //For any other condition output "Oh man, get some sleep!"
        {
            int hoursSlept = 2;
            if (hoursSlept >= 10)
            {
                Console.WriteLine("Wow! That's a lot of sleep!");
            }
            else if (hoursSlept >= 8 && hoursSlept < 10)
            {
                Console.WriteLine("You should be pretty well-rested.");
            }
            else if (hoursSlept > 4 && hoursSlept < 8)
            {
                Console.WriteLine("Bummer!");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
        }

        [TestMethod]
        public void Part9a()
        //Write out a switch case that evaluates a variable that holds the value for how the user's day has been.
        //Have a case for: "Great", "Good", "Okay", "Bad", ":(" and output a response to the Console for each.


        //Don't know how to take user input...
        {
            Console.WriteLine("Rate your day from 1-5:");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine(":(");
                    break;
                case 2:
                    Console.WriteLine("Bad");
                    break;
                case 3:
                    Console.WriteLine("Okay");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Great");
                    break;
            }

        }

        [TestMethod]
        public void Part9b()
        {
            Console.WriteLine("Rate your day from 1-5:");
            int input = 3;

            switch (input)
            {
                case 1:
                    Console.WriteLine(":(");
                    break;
                case 2:
                    Console.WriteLine("Bad");
                    break;
                case 3:
                    Console.WriteLine("Okay");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Great");
                    break;
            }

        }
    }
}
