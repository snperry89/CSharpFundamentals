using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat something!");
            }
            //one = sign is assigning value, 2 = signs means 'is equal to'
            //use single quotes is for one char, double quotes is for string

            int hoursSpentStudying = 8;
            if (hoursSpentStudying < 15)
            {
                Console.WriteLine("Are you even trying?");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            //anytime you have a boolean, it checks to see if it is true

            //type  //var name    //var value
            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Have fun playing video games!");
            }
            else
            {
                Console.WriteLine("Get your chores done, son!");
            }
            //whenever we get information from console, it comes in the form of a string
            string input = "3";
            int totalHours = int.Parse(input);

            if (totalHours >= 8)
            {
                Console.WriteLine("You should be well rested.");
            }
            else
            {
                Console.WriteLine("You might be tired today.");
                if (totalHours < 4)
                {
                    Console.WriteLine("Yikes...Get some sleep.");
                }
            }
        }

        [TestMethod]
        public void IfElseIfStatements()
        {
            int age = 55;

            if (age > 17)
            {
                Console.WriteLine("You're an adult.");
            }
            else
            {
                if (age > 6)
                {
                    Console.WriteLine("You're a kid.");
                }
                else if (age > 0)
                {
                    Console.WriteLine("You're too young to be on this computer.");
                }
                else
                {
                    Console.WriteLine("You're not even born yet.");
                }
            }

            if (age < 65 && age > 18)
            {
                Console.WriteLine("Age is between 18 and 65");
            }
            if (age == 55)
            {
                Console.WriteLine("You're a senior citizen now!");
            }

        }
        // quiz test w1d3
        [TestMethod]
        public int GetLarge(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        [TestMethod]
        public int GetAge(DateTime birthday)

        {

            TimeSpan ageSpan = DateTime.Now - birthday;

            double totalAgeDays = ageSpan.TotalDays;

            double totalAgeYears = totalAgeDays / 365.25; // doesnt recognize age //

            int years = Convert.ToInt32(Math.Floor(totalAgeYears));

            return years;

        }
        [TestMethod]
        public void Greeter(string name)
        {
            Console.WriteLine($"Howdy {name}.");
        }

        [TestMethod]
        public double GetQuotient(int a, int b)

        {

            double quotient = a / b;

            return quotient;

        }

        //public int TryParse(string)

        //{

        //    int num1 = ("string");

        //    return num1;

        //}
        [TestMethod]
        public void FizzOrBuzz(int input)

        {
            for (int a = 1; a <= input; a++)
                if (input % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
            else if (input % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (input % 3 == 0 && input % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine(a);
            }
        }

        //[TestMethod]
        //public int StringToInt(string input)
        //{
        //    int num1;
        //    if (int.TryParse(input, out num1))
        //    {
        //        return num1;
        //    }
        //    else
        //    {
        //        return null;
        //    }

        //}

        //[TestMethod]
        //    public int StringToInt(string input)
        //    {
        //        int num1;
        //    if (int.TryParse(input, out num1))
        //    {
        //        return num1;

        //    }

        //    }

        //}

        //[TestMethod]
        //public void FizzOrBuzz(int input)
        //{
        //    for (int a = 1; a <= input; a++)
        //    {
        //        if (a % 15 == 0)
        //        {
        //            Console.WriteLine("FizzBuzz");
        //        }
        //        else if (a % 3 == 0)
        //        {
        //            Console.WriteLine("Fizz");
        //        }
        //        else if (a % 5 == 0)
        //        {
        //            Console.WriteLine("Buzz");
        //        }
        //        else
        //        {
        //            Console.WriteLine(a);
        //        }
        //    }
        [TestMethod]
        public int GetStringToInt(string input)
        {           
            int output;
            int.TryParse(input, out output);
            return output;
        }
    }
}


