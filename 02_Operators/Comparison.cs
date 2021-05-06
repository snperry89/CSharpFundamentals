using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
//Using System; Collections; Generic

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 32;
            string userName = "Samuel";

            bool isEqual = age == 41; //the value of isEqual depends on the comparison in the ()
            Console.WriteLine(isEqual);

            bool userIsMichael = userName == "Michael";
            Console.WriteLine(userIsMichael);

            bool isNotEqual = age != 23;
            Console.WriteLine(isNotEqual);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = firstList == secondList;
            //Console.WriteLine(listsAreEqual);

            //Although these have the same content, they are seperate lists stored in seperate locations: (ie same house blueprint but on two seperate streets)

            bool isGreaterThan = age > 36;
            Console.WriteLine(isGreaterThan); // false

            bool isLessThan = age < 36;
            Console.WriteLine(isLessThan); // true

            bool isGreaterorEqual = age >= 41;
            Console.WriteLine(isGreaterorEqual); //false


            bool isTrue = true;
            bool isFalse = false;

            bool andValue = isTrue && isFalse;

            bool anotherAndValue = age == 25 && userName == "Jacob" && isTrue == true;
            bool orValue = age == 25 || userName == "Michael";

        }
    }
}
