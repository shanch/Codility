using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lessons.Lesson6
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestSample()
        {
            var test = new Triangle();

            Assert.AreEqual(1, test.Solution(new int[] { 10, 2, 5, 1, 8, 20 }));

        }

        [TestMethod]
        public void TestSample2()
        {
            var test = new Triangle();

            Assert.AreEqual(0, test.Solution(new int[] { 10, 50, 5, 1 }));

        }

        [TestMethod]
        public void TestMax()
        {
            var test = new Triangle();
            
            Assert.AreEqual(1, test.Solution(new int[] { int.MaxValue, int.MaxValue -1 , int.MaxValue-2}));

        }
    }
}
