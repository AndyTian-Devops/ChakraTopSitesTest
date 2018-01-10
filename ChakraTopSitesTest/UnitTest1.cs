using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace ChakraTopSitesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EdgeDriver driver = new EdgeDriver();

            driver.Url = "https://www.microsoft.com/";

            driver.Quit();
        }
    }
}
