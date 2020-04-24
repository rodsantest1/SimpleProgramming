using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class AppiumTests : WpfAppSession
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }

        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var input1 = session.FindElementByAccessibilityId("addendTextBox1");
            input1.SendKeys("1");
            var input2 = session.FindElementByAccessibilityId("addendTextBox2");
            input2.SendKeys("2");
            //act
            var sumButton = session.FindElementByAccessibilityId("sumButton");
            sumButton.Click();
            //assert
            var sumText = session.FindElementByAccessibilityId("sumTextBox");
            Assert.AreEqual("3", sumText.Text);
        }
    }
}
