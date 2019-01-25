using System;
using System.Diagnostics;
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
            TextWriterTraceListener myListener = new TextWriterTraceListener("TextWriterOutput.log", "myListener");

            IWebDriver driver = new ChromeDriver(@"C:\chromedriver");
            driver.Navigate().GoToUrl("https://www.servicenow.com/");
            myListener.WriteLine(driver.PageSource); 
            myListener.Flush();
            driver.Quit();
        }
    }
}
