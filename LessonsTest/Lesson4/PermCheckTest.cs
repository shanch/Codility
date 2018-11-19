using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Lessons.Lesson4
{
    [TestClass]
    public class PermCheckTest
    {
        [TestMethod]
        public void TestSamplePerm()
        {
            var testClass = new PermCheck();

            Assert.AreEqual(1, testClass.Solution(new int[] { 4, 1, 3, 2 }));
        }

        [TestMethod]
        public void TestSampleNonPerm()
        {
            var testClass = new PermCheck();

            Assert.AreEqual(0, testClass.Solution(new int[] { 4, 1, 3 }));
        }

        [TestMethod]
        public void TestMinArrayLengthPerm()
        {
            var testClass = new PermCheck();

            Assert.AreEqual(1, testClass.Solution(new int[] { 1 }));
        }

        [TestMethod]
        public void TestMinArrayLengthNonPerm()
        {
            var testClass = new PermCheck();

            Assert.AreEqual(0, testClass.Solution(new int[] { 4 }));
        }

        [TestMethod]
        public void TestMaxArrayLengthPerm()
        {
            var testClass = new PermCheck();

            Assert.AreEqual(1, testClass.Solution(Enumerable.Range(1, 100000).ToArray()));
        }

        [TestMethod]
        public void TestMaxArrayLengthNonPerm()
        {
            var testClass = new PermCheck();

            Assert.AreEqual(0, testClass.Solution(Enumerable.Concat(Enumerable.Range(1, 99999), new int[] { 1 }).ToArray()));
        }
    }
}
