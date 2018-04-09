using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;

namespace PageObjectPattern
{
   public static class DriverHelper
    {
        public static IWebDriver Driver { get; private set; }
        private static string _baseUrl = "http://demo.net-art.eu/";
        private enum Drivers
        {
            Chrome,
            Firefox,
            IE
        }
        private static IWebDriver GetDriver(Drivers driver)
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
        public static void Initialize()
        {
            Driver = GetDriver(Drivers.Chrome);
            Goto("konfigurator3d");
            MaximizeWindow();
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
        public static void Quit()
        {
            Driver.Quit();
        }
    }
}
