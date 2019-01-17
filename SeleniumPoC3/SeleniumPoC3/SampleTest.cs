using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumPoC3
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\svc_surfqacoe\Documents");
            driver.Navigate().GoToUrl("https://www.servicenow.com/");
            System.Console.WriteLine("Hellow world");
            System.Console.WriteLine(driver.PageSource);
            driver.Quit();
        }
    }
}
