using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lessons.Lesson8
{
    [TestClass]
    public class EquiLeaderTest
    {
        [TestMethod]
        public void TestSample()
        {
            var test = new EquiLeader();

            Assert.AreEqual(2, test.Solution(new int[] { 4, 3, 4, 4, 4, 2 }));

        }

        [TestMethod]
        public void TestSample2()
        {
            var test = new EquiLeader();

            Assert.AreEqual(4, test.Solution(new int[] { 4, 3, 4, 4, 4, 2, 4 }));

        }

        [TestMethod]
        public void TestSample3()
        {
            var test = new EquiLeader();

            Assert.AreEqual(1, test.Solution(new int[] { -1000000000, -1000000000 }));

        }
    }
}
