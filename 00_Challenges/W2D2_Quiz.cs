using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class W2D2_Quiz
    {
        public double GetSumOfTwoNumbers(double x, double y);

        [TestMethod]
        public void GetSumTest()
        {
            var actual = GetSumOfTwoNumbers(1, 4);
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }
    }
}
