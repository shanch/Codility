using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lessons.Lesson9
{
    [TestClass]
    public class MaxSliceSumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testClass = new MaxSliceSum();

            Assert.AreEqual(5, testClass.Solution(new int[] { 3, 2, -6, 4, 0 }));

        }

        [TestMethod]
        public void TestMethod2()
        {
            var testClass = new MaxSliceSum();

            Assert.AreEqual(int.MinValue, testClass.Solution(new int[] { int.MinValue }));

        }

        [TestMethod]
        public void TestMethod3()
        {
            var testClass = new MaxSliceSum();

            Assert.AreEqual(1000000, testClass.Solution(Enumerable.Repeat(1,1000000).ToArray()));

        }
    }
}
