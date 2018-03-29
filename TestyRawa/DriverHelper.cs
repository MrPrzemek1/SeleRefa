using System;
using System.IO;
using System.Reflection;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestyRawa
{
    public class DriverHelper
    {
        public enum Drivers
        {
            Chrome,
            Firefox,
            IE
        }
        public static class Browser
        {
            private static IWebDriver _webDriver;
            private static string _baseUrl = "http://demo.net-art.eu/";
            internal static void SwitchTabs(int tabIndex)
            {
                var windows = _webDriver.WindowHandles;
                _webDriver.SwitchTo().Window(windows[tabIndex]);
            }
            public static IWebDriver GetDriver(Drivers driver)
            {
                //added to handle the firefox driver
                switch (driver)
                {
                    case Drivers.Chrome:
                        var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        var relativePath = @"..\..\..\TestyRawa\bin\debug";
                        var chromeDriverPath = Path.GetFullPath(Path.Combine(outPutDirectory, relativePath));
                        return new ChromeDriver(chromeDriverPath);
                    case Drivers.Firefox:
                        return new FirefoxDriver();
                    default:
                        throw new NotImplementedException("I do not know the driver that you supplied.");
                }
            }
            public static bool WaitUntilElementIsDisplayed(By element, int timeoutInSeconds)
            {
                for (int i = 0; i < timeoutInSeconds; i++)
                {
                    if (ElementIsDisplayed(element))
                    {
                        return true;
                    }
                    Thread.Sleep(1000);
                }
                return false;
            }

            internal static IWebElement FindElement(By by)
            {
                return _webDriver.FindElement(by);
            }

            public static bool ElementIsDisplayed(By element)
            {
                var present = false;
                _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
                try
                {
                    present = _webDriver.FindElement(element).Displayed;
                }
                catch (NoSuchElementException)
                {
                }
                _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                return present;
            }

            public static IWebDriver Driver { get { return _webDriver; } }
            public static string Title { get { return _webDriver.Title; } }

            public static void Initialize()
            {
                _webDriver = GetDriver(Drivers.Chrome);
                Goto("konfigurator3d");
                WaitUntilElementIsDisplayed(By.XPath("//button[@class='btn btn-primary btn-lg btn-start']"), 5);
                MaximizeWindow();
            }

            public static void Close()
            {
                _webDriver.Close();
            }

            public static void Goto(string url, bool useBaseUrl = true)
            {
                if (useBaseUrl)
                    _webDriver.Navigate().GoToUrl(string.Format("{0}/{1}", _baseUrl, url));
                else
                    _webDriver.Navigate().GoToUrl(url);
            }
            public static void MaximizeWindow()
            {
                _webDriver.Manage().Window.Maximize();
            }
            public static void Quit()
            {
                _webDriver.Quit();
            }
            public static void ClickOnElement (By element)
            {
                _webDriver.FindElement(element).Click();
            }
            public static string GetElementAttribute(By element, string attributeName)
            {
                return _webDriver.FindElement(element).GetAttribute(attributeName);
            }
        }
    }
}
