using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestApp.MathOperations.Double(20);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(40, TestApp.MathOperations.Double(20));
        }

        [TestMethod]
        public void TestMethod3()
        {
            TestApp.MathOperations.Triple(20);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(60, TestApp.MathOperations.Triple(20));
        }
    }
}
