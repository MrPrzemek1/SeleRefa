using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace RawaTests.Helpers.DriverHelper
{
    public static class DriverHelp
    {
        private static string _baseUrl = "http://demo.net-art.eu/";
        public static IWebDriver Driver { get; private set; }
        public static string Title { get { return Driver.Title; } }
        private static WebDriverWait wait;
        private static IWebElement element;

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
        public static IWebElement FindElement(By by, int second=3)
            {
                wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(second));
                IWebElement result;

                try
                { 
                    result = wait.Until(ExpectedConditions.ElementIsVisible(by));
                }
                catch (Exception)
                {
                    result = null;
                }
                return result;
            }
        public static IList<IWebElement> FindElements(By by, int second=5)
        {
            IList<IWebElement> result = new List<IWebElement>();
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(second));
            try
            {
                IWebElement loader =  wait.Until(ExpectedConditions.ElementExists(By.ClassName("loading")));
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
        public static IWebElement LoadingImage()
        {
            try
            {
                return Driver.FindElement(By.ClassName("loading-show"));
            }
            catch
            {
                return null;
            }
        }
        public static IWebElement Wait(int seconds)
        {
            try
            {
                var loading = LoadingImage();
                DateTime date = DateTime.Now.AddSeconds(seconds);
                while (loading != null && date > DateTime.Now)
                {
                    Thread.Sleep(200);
                    loading = LoadingImage();
                }
                return element;
            }
            catch
            {
                return null;
            }
        }
    }
}


