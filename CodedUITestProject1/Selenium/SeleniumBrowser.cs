using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.Selenium
{
    public class SeleniumBrowser
    {
        private readonly RemoteWebDriver driver;

        public SeleniumBrowser(RemoteWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GoToUrl(string url)
        {
            Uri uri = new Uri(url);
            driver.Navigate().GoToUrl(uri);
            WaitForLoad();
        }

        public void WaitForLoad(int timeout = 30)
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(timeout);
        }
    }
}
