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
    public class StringProblemsTests
    {
        [TestMethod]
        public void TestGetAllAnagrams()
        {
            string input = "abcde";
            string[] actual = StringProblems.GetAllAnagramsOfString(input).ToArray();

            Assert.AreEqual(actual.Length, 120);
        }
    }
}
