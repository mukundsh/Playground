using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playground2;

namespace PlaygroundTests
{
    [TestClass]
    public class ArrayProblemsTests
    {
        [TestMethod]
        public void FindLastIndexOfElementTests()
        {
            int[] arr = { 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 4 };
            int lastIndexOfOne = ArrayProblems.FindLastIndexOfElement(arr, key: 1, lo: 0, hi: arr.Length - 1);
            Assert.AreEqual(2, lastIndexOfOne);
            int lastIndexOfTwo = ArrayProblems.FindLastIndexOfElement(arr, key: 2, lo: 0, hi: arr.Length - 1);
            Assert.AreEqual(7, lastIndexOfTwo);
            int lastIndexOfThree = ArrayProblems.FindLastIndexOfElement(arr, key: 3, lo: 0, hi: arr.Length - 1);
            Assert.AreEqual(9, lastIndexOfThree);
            int lastIndexOfFour = ArrayProblems.FindLastIndexOfElement(arr, key: 4, lo: 0, hi: arr.Length - 1);
            Assert.AreEqual(10, lastIndexOfFour);
        }
    }
}
