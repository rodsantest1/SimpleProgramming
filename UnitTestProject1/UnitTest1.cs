using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTestMethod()
        {
            //arrange
            int expected = 2;
            int actual = 0;
            //act
            actual = ClassLibrary1.Class1.AddMethod("1", "1");
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
