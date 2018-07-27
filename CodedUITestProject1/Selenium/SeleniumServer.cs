using AutomationTesting.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace AutomationTesting.Selenium
{
    internal class SeleniumServer
    {
        public static RemoteWebDriver Start(SeleniumDrivers.Drivers driver = SeleniumDrivers.Drivers.Chrome)
        {
            LaunchSelenium();
            return SetDriver(driver);
        }

        public static void LaunchSelenium()
        {
            string jarPath = @"C:\Selenium\SeleniumServer\selenium-server-standalone-3.9.1.jar";
            ProcessStartInfo seleniumStartInfo = new ProcessStartInfo("java", @"-jar " + jarPath); //if file not found, verify java is installed
            seleniumStartInfo.UseShellExecute = false;
            Process.Start(seleniumStartInfo);
            //allow time to start
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        public static RemoteWebDriver SetDriver(SeleniumDrivers.Drivers driver)
        {
            RemoteWebDriver webDriver = null;
            const string DRIVERPATH = @"C:\Selenium\WebDrivers";

            switch(driver)
            {
                case SeleniumDrivers.Drivers.Chrome:
                    webDriver = new ChromeDriver(DRIVERPATH);
                    break;
                case SeleniumDrivers.Drivers.Firefox:
                    webDriver = new FirefoxDriver(DRIVERPATH);
                    break;
                case SeleniumDrivers.Drivers.InternetExplorer:
                    webDriver = new InternetExplorerDriver(DRIVERPATH);
                    break;
                case SeleniumDrivers.Drivers.PhantomJs:
                    webDriver = new RemoteWebDriver(DesiredCapabilities.PhantomJS());
                    break;
            }

            if(driver != SeleniumDrivers.Drivers.PhantomJs)
            {
                webDriver.Manage().Window.Maximize();
            }

            return webDriver;
        }

        public static void Cleanup(RemoteWebDriver driver)
        {
            //quit selenium
            driver?.Quit();
            //kill any hanging selenium process
            foreach(Process process in Process.GetProcessesByName("java"))
            {
                process.Kill();
            }
        }
    }
}
