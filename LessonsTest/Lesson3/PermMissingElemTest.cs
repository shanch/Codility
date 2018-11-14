using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lessons.Lesson3
{
    [TestClass]
    public class PermMissingElemTest
    {
        [TestMethod]
        public void TestSample()
        {
            var testClass = new PermMissingElem();

            Assert.AreEqual(4, testClass.Solution(new int[] { 2, 3, 1, 5 }));
        }

        [TestMethod]
        public void TestMax()
        {
            var testClass = new PermMissingElem();

            var param = Enumerable.Range(2, 100000);
            
            Assert.AreEqual(1, testClass.Solution(param.ToArray()));
        }
    }
}
