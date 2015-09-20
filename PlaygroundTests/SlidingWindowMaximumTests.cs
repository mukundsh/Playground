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
    public class SlidingWindowMaximumTests
    {
        [TestMethod]
        public void TestSlidingWindowMaximum()
        {
            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int windowSize = 3;
            int[] slidingWindowMaximums = SlidingWindowMaximum.GetSlidingWindowMaximum(arr, windowSize).ToArray();
            CollectionAssert.AreEqual(new int[] { 3, 3, 5, 5, 6, 7 }, slidingWindowMaximums);
        }
    }
}
