using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lessons.Lesson7
{
    [TestClass]
    public class BracketsTest
    {
        [TestMethod]
        public void TestSample()
        {
            var test = new Brackets();

            Assert.AreEqual(1, test.Solution("{[()()]}"));
        }

        [TestMethod]
        public void TestSample2()
        {
            var test = new Brackets();

            Assert.AreEqual(0, test.Solution("([)()]"));
        }

        [TestMethod]
        public void TestSample3()
        {
            var test = new Brackets();

            Assert.AreEqual(0, test.Solution(")("));
        }

        [TestMethod]
        public void TestSample4()
        {
            var test = new Brackets();

            Assert.AreEqual(0, test.Solution("{{{{"));
        }
    }
}
