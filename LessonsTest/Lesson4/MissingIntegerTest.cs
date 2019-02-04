using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lessons.Lesson4
{
    [TestClass]
    public class MissingIntegerTest
    {
        [TestMethod]
        public void TestSample1()
        {
            var testClass = new MissingInteger();

            var actual = testClass.Solution(new int[] { 1, 3, 6, 4, 1, 2 });

            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void TestSample2()
        {
            var testClass = new MissingInteger();

            var actual = testClass.Solution(new int[] { 1, 2, 3 });

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestSample3()
        {
            var testClass = new MissingInteger();

            var actual = testClass.Solution(new int[] { -1, -3 });

            Assert.AreEqual(1, actual);
        }

    }
}
