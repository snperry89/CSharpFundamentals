using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// Create a Calculator class that has the ability to complete all of the following processes, each taking in two number inputs:
// Write Unit Tests for all of your calculator's functionalities.

// Allow use of whole numbers and numbers with decimals
// ???isnt this just making the variables doubles???



namespace _00_Challenges
{
    [TestClass]
    public class Calculator
    {
        public double Sum(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }
        
        public int Sum(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public double Diff(double numOne, double numTwo)
        {
            return numOne - numTwo;
        }

        public double Prod(double numOne, double numTwo)
        {  
            return numOne * numTwo;
        }

        public double Quot(double numOne, double numTwo)
        {
            return numOne / numTwo;
        }

        public double Remain(double numOne, double numTwo)
        {
            return numOne % numTwo;
        }

        [TestMethod]
        public void Sum()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(11, calc.Sum(5, 6));
            Assert.AreEqual(5, Math.Floor(calc.Sum(3.4, 2)));
            Assert.AreEqual(113, calc.Sum(new double[] { 32, 12, 59, 10 }));
        }

        [TestMethod]
        public void Diff()
        {

        }
    }
    
}
