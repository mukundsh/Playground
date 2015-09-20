using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground2;

namespace PlaygroundTests
{
    [TestClass]
    public class KthMagicalNumberTests
    {
        [TestMethod]
        public void TestKthMagicalNumber()
        {
            //5, 25, 25+5=30, 125, 125+5=130, 125+25=150, 125+25+5=155,….
            long[] magicalNumbers = { 5, 25, 30, 125, 130, 150, 155 };

            for (int i = 0; i < magicalNumbers.Length; i++)
            {
                Assert.AreEqual(magicalNumbers[i], KthMagicalNumber.FindKthMagicalNumber(i + 1));
            }
        }
    }
}
