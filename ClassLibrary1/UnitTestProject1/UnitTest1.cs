using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int actual= Class1.Add(1, 2);
            int expect = 3;
            Assert.AreEqual(expect, actual);
        }
    }
}
