using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment2;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetLength_ValidLength_1()
        {
            Rectangle rectangle = new Rectangle();
            int expected = 1;
            Assert.AreEqual(expected, rectangle.GetLength());
        }
    }
}
