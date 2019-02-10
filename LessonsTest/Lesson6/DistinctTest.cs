using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lessons.Lesson6
{
    [TestClass]
    public class DistinctTest
    {
        [TestMethod]
        public void TestSample()
        {
            var testClass = new Distinct();

            Assert.AreEqual(3, testClass.Solution(new int[] { 2, 1, 2, 2, 3, 1 }));
        }
    }
}
