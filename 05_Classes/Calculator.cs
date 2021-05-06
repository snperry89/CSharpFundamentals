using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        //addition                //parameters Quiz Question Heads-up...
        public double GetSum(double numOne, double numTwo)
        {
            double sumSolution = numOne + numTwo;
            return sumSolution;
        }

        public double GetQuotient(int a, int b)
        {
            double quotient = a / b;
            return quotient;
        }
        
        //subtraction
        //multiplication
        //division

        public int CalculateAge(DateTime birthday)
        {
            //type used when performing math equation with multiple DateTimes
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInDays = ageSpan.TotalDays;
            double totalAgeInYears = totalAgeInDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}
