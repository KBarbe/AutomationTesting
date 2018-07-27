using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using AutomationTesting.Selenium;

namespace AutomationTesting.Tests.SeleniumTests
{
    /// <summary>
    /// Performing a Google Search using Selenium
    /// This test assumes the JAR file for Selenium Stand Alone Server is located at C:\Selenium\SeleniumServer
    /// This test assumes the Chrome WebDriver is located at C:\Selenium\WebDrivers
    /// </summary>
    [CodedUITest]
    public class GoogleSearchTest
    {
        //start selenium -- defaulted to use chrome
        private readonly RemoteWebDriver driver = SeleniumServer.Start();

        [TestMethod]
        public void GoogleSearch_test()
        {
            //initialize selenium browser
            SeleniumBrowser browser = new SeleniumBrowser(driver);

            //open google
            browser.GoToUrl("https://www.google.com/");

            //enter search text
            driver.FindElementById("lst-ib").SendKeys("Testing with Selenium");

            //click search
            driver.FindElementByCssSelector("[type='submit']").Click();
            browser.WaitForLoad();

            //open selenium link
            driver.FindElementByXPath("//a[@href='https://www.seleniumhq.org/']").Click();
        }
    }
}
