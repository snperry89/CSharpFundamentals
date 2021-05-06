using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void SwitchCases()
        {
            //take input, evaluate it, and check a specific case vs. input value

            int input = 55;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                    //break command will break the cycle
                case 2:
                    Console.WriteLine(" World!");
                    break;
                case 55:
                    Console.WriteLine("Huh???");
                    break;
                //default behaves like an else statement in this situation
                default:
                    Console.WriteLine("What are you doing?");
                    break;
            }
        }
    }
}
