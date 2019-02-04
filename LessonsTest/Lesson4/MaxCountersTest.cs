using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lessons.Lesson4
{
    [TestClass]
    public class MaxCountersTest
    {
        [TestMethod]
        public void TestSample()
        {
            var testClass = new MaxCounters();

            var actual = testClass.Solution(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });
            var expected = new int[] { 3, 2, 2, 4, 2 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinNM()
        {
            var testClass = new MaxCounters();

            var actual = testClass.Solution(1, new int[] { 1 });
            var expected = new int[] { 1 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinN_MaxM()
        {
            var testClass = new MaxCounters();

            var actual = testClass.Solution(1, Enumerable.Repeat(1, 100000).ToArray());
            var expected = new int[] { 100000 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMinN_MaxM2()
        {
            var testClass = new MaxCounters();

            var actual = testClass.Solution(1, Enumerable.Repeat(2, 100000).ToArray());
            var expected = new int[] { 0 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMaxN_MaxM()
        {
            var testClass = new MaxCounters();

            var actual = testClass.Solution(100000, Enumerable.Repeat(100001, 100000).ToArray());
            var expected = Enumerable.Repeat(0, 100000).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
