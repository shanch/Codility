using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lessons.Lesson8
{
    [TestClass]
    public class DominatorTest
    {
        [TestMethod]
        public void TestMethodSample()
        {
            var test = new Dominator();

            Assert.AreEqual(7, test.Solution(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 }));

        }

        [TestMethod]
        public void TestMethodSample2()
        {
            var test = new Dominator();

            Assert.AreEqual(1, test.Solution(new int[] { 2147483647, 2147483647 }));

        }

        [TestMethod]
        public void TestMethodSample3()
        {
            var test = new Dominator();

            Assert.AreEqual(1, test.Solution(new int[] { -2147483647, -2147483647 }));

        }

        [TestMethod]
        public void TestMethodSample4()
        {
            var test = new Dominator();

            Assert.AreEqual(-1, test.Solution(new int[] { -2147483647, 2147483647 }));

        }

        [TestMethod]
        public void TestMethodSample5()
        {
            var test = new Dominator();

            Assert.AreEqual(0, test.Solution(new int[] { -2147483647 }));

        }

        [TestMethod]
        public void TestEmpty()
        {
            var test = new Dominator();

            Assert.AreEqual(-1, test.Solution(new int[0] ));

        }
    }
}
