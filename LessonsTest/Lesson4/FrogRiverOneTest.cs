using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lessons.Lesson4
{
    [TestClass]
    public class FrogRiverOneTest
    {
        [TestMethod]
        public void TestSample()
        {
            var testClass = new FrogRiverOne();

            var actual = testClass.Solution(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 });

            Assert.AreEqual(6, actual);
        }
    }
}
