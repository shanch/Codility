using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lessons.Lesson2
{
    [TestClass]
    public class OddOccurrencesInArrayTest
    {
        [TestMethod]
        public void TestSample()
        {
            var testClass = new OddOccurrencesInArray();

            Assert.AreEqual(7, testClass.Solution(new int[] { 9, 3, 9, 3, 9, 7, 9 }));
        }

        [TestMethod]
        public void TestNequalsOne()
        {
            var testClass = new OddOccurrencesInArray();

            Assert.AreEqual(9, testClass.Solution(new int[] { 9 }));
        }

        [TestMethod]
        public void TestNequalsMax()
        {
            var testClass = new OddOccurrencesInArray();

            int[] args = new int[999999];
            for(int i=0; i<args.Length; i++)
            {
                args[i] = 1;
            }

            Assert.AreEqual(1, testClass.Solution(args));
        }

        [TestMethod]
        public void TestElementlsMax()
        {
            var testClass = new OddOccurrencesInArray();

            Assert.AreEqual(1000000000, testClass.Solution(new int[] { 1000000000, 1, 1 }));
        }
    }
}
