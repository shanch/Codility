using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lessons.Lesson3
{
    [TestClass]
    public class TapeEquilibriumTest
    {
        [TestMethod]
        public void TestSsample()
        {
            var testClass = new TapeEquilibrium();

            Assert.AreEqual(1, testClass.Solution(new int[] { 3, 1, 2, 4, 3 }));
        }

        [TestMethod]
        public void TestPerformance()
        {
            var testClass = new TapeEquilibrium();

            var sw = new Stopwatch();

            sw.Start();

            for (int i = 0; i < 10000; i++)
            {
                testClass.Solution(new int[] { 3, 1, 2, 4, 3 });
            }

            sw.Stop();

            Console.WriteLine(sw.Elapsed.Milliseconds);

            sw.Restart();

            for (int i = 0; i < 10000; i++)
            {
                testClass.SolutionVer1(new int[] { 3, 1, 2, 4, 3 });
            }

            sw.Stop();

            Console.WriteLine(sw.Elapsed.Milliseconds);

            sw.Restart();

            for (int i = 0; i < 10000; i++)
            {
                testClass.SolutionVer2(new int[] { 3, 1, 2, 4, 3 });
            }

            sw.Stop();

            Console.WriteLine(sw.Elapsed.Milliseconds);
        }

        [TestMethod]
        public void TestMinN()
        {
            var testClass = new TapeEquilibrium();

            Assert.AreEqual(2, testClass.Solution(new int[] { 3, 1 }));
        }

        [TestMethod]
        public void TestMinNPlus1()
        {
            var testClass = new TapeEquilibrium();

            Assert.AreEqual(0, testClass.Solution(new int[] { 3, 1, 2 }));
        }

        [TestMethod]
        public void TestMaxN()
        {
            var testClass = new TapeEquilibrium();

            Assert.AreEqual(0, testClass.Solution(Enumerable.Repeat(1, 100000).ToArray()));
        }

        [TestMethod]
        public void TestMaxElement()
        {
            var testClass = new TapeEquilibrium();

            Assert.AreEqual(0, testClass.Solution(Enumerable.Repeat(1000, 100000).ToArray()));
        }

        [TestMethod]
        public void TestMinElement()
        {
            var testClass = new TapeEquilibrium();

            Assert.AreEqual(0, testClass.Solution(Enumerable.Repeat(-1000, 100000).ToArray()));
        }
    }
}
