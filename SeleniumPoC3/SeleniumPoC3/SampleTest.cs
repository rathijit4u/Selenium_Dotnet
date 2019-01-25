using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.Dynamics365.UIAutomation.Api;
using Microsoft.Dynamics365.UIAutomation.Browser;



namespace SeleniumPoC3
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //TextWriterTraceListener myListener = new TextWriterTraceListener("TextWriterOutput.log", "myListener");

           // IWebDriver driver = new ChromeDriver(@"C:\chromedriver");
          //  driver.Navigate().GoToUrl("https://www.servicenow.com/");
          //  myListener.WriteLine(driver.PageSource); 
         //   myListener.Flush();
          //  driver.Quit();

            using(var xmBrowser = new Browser(new BrowserOptions { BrowserType= BrowserType.Chrome
            }))
            {
                xmBrowser.LoginPage.Login(new Uri("https://www.servicenow.com/"),
                    "admin".ToSecureString(), "admin".ToSecureString());
            }
        }
    }
}
