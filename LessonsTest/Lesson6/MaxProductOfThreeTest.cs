using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lessons.Lesson6
{
    [TestClass]
    public class MaxProductOfThreeTest
    {
        [TestMethod]
        public void TestSample()
        {
            var testClass = new MaxProductOfThree();

            Assert.AreEqual(60, testClass.Solution(new int[] { -3, 1, 2, -2, 5, 6 }));

        }

        [TestMethod]
        public void TestSample2()
        {
            var testClass = new MaxProductOfThree();

            Assert.AreEqual(-80, testClass.Solution(new int[] { -10, -2, -4 }));

        }

        [TestMethod]
        public void TestSample3()
        {
            var testClass = new MaxProductOfThree();

            Assert.AreEqual(1000*1000*1000, testClass.Solution(Enumerable.Repeat<int>(1000, 100000).ToArray()));

        }
    }
}
