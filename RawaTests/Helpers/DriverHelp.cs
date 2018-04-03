using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace RawaTests.Helpers.DriverHelper
{
    public static class DriverHelp
    {
        private static string _baseUrl = "http://demo.net-art.eu/";
        public static IWebDriver Driver { get; private set; }
        public static string Title { get { return Driver.Title; } }

        public enum Drivers
        {
            Chrome,
            Firefox,
            IE
        }
        public static IWebDriver GetDriver(Drivers driver)
        {
            switch (driver)
            {
                case Drivers.Chrome:
                    var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    var relativePath = @"..\..\..\RawaTests\bin\debug";
                    var chromeDriverPath = Path.GetFullPath(Path.Combine(outPutDirectory, relativePath));
                    return new ChromeDriver(chromeDriverPath);
                case Drivers.Firefox:
                    return new FirefoxDriver();
                default:
                    throw new NotImplementedException("I do not know the driver that you supplied.");
            }
        }
        public static IWebElement FindElement(By by)
            {
                IWebElement result;
                try
                {
                    result = Driver.FindElement(by);
                }
                catch (Exception)
                {
                    result = null;
                }
                return result;
            }
        public static IList<IWebElement> FindElements(By by)
        {
            IList<IWebElement> result = new List<IWebElement>();
            try
            {
                 result = Driver.FindElements(by);
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }

        public static void Goto(string url, bool useBaseUrl = true)
            {
                if (useBaseUrl)
                    Driver.Navigate().GoToUrl(string.Format("{0}/{1}", _baseUrl, url));
                else
                    Driver.Navigate().GoToUrl(url);
            }
        public static void MaximizeWindow()
            {
                Driver.Manage().Window.Maximize();
            }
        public static void Initialize()
            {
                Driver = GetDriver(Drivers.Chrome);
                Goto("konfigurator3d");
                MaximizeWindow();
            }
        public static void Quit()
        {
            Driver.Quit();
        }
    }
}


