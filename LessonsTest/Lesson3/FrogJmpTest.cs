using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lessons.Lesson3
{
    [TestClass]
    public class FrogJmpTest
    {
        [TestMethod]
        public void TestSample()
        {
            var testClass = new FrogJmp();

            Assert.AreEqual(3, testClass.Solution(10, 85, 30));
        }

        [TestMethod]
        public void TestXequalsY()
        {
            var testClass = new FrogJmp();

            Assert.AreEqual(3, testClass.Solution(10, 100, 30));
        }

        [TestMethod]
        public void TestMaxBoundary()
        {
            var testClass = new FrogJmp();

            Assert.AreEqual(1, testClass.Solution(1000000000 - 1, 1000000000, 1000000000));
        }

        [TestMethod]
        public void TestPerformance()
        {
            var testClass = new FrogJmp();

            Assert.AreEqual(999999999, testClass.Solution(1, 1000000000, 1));
        }
    }
}
