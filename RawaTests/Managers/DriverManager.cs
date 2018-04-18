using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RawaTests.Helpers.DriverHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace RawaTests.Managers
{
    public class DriverManager
    {
        private const string _baseUrl = "http://demo.net-art.eu/";

        private static DriverManager Instance;
        public static DriverManager CreateInstance(DriverType type = DriverType.Chrome)
        {
            if (Instance == null || Instance.CurrentDriverType != type)
            {
                Instance = new DriverManager(type);
                Instance.Initialize();
            }
            return Instance;
        }
        private static void Clear()
        {
            Instance = null;
        }
       
        public IWebDriver Driver { get; private set; }

        public DriverType CurrentDriverType { get; private set; }

        public string Title { get { return Driver.Title; } }

        private DriverManager(DriverType type)
        {
            CurrentDriverType = type;
            Driver = GetDriver(type);
        }

        private IWebDriver GetDriver(DriverType driver)
        {
            switch (driver)
            {
                case DriverType.Chrome:
                    var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    var relativePath = @"..\..\..\RawaTests\bin\debug";
                    var chromeDriverPath = Path.GetFullPath(Path.Combine(outPutDirectory, relativePath));
                    return new ChromeDriver(chromeDriverPath);
                case DriverType.Firefox:
                    return new FirefoxDriver();
                default:
                    throw new NotImplementedException("I do not know the driver that you supplied.");
            }
        }
        #region Wyszukiwanie i czekanie na elementy.

        public IWebElement FindWebElementAndWait(By by)
        {
            return DriverHelper.FindWebElementAndWait(Driver, by);
        }
        public IList<IWebElement> FindWebElementsAndWait(By by)
        {
            return DriverHelper.FindWebElementsAndWait(Driver, by);
        }

        #endregion

        #region Wyszukiwanie elementów bez czekania na nie
        public IWebElement FindWebElement(By by)
        {
            return DriverHelper.FindWebElementWithoutWait(Driver, by);
        }
       
        public IList<IWebElement> FindWebElements(By by)
        {
            return DriverHelper.FindWebElementsWithoutWait(Driver, by);
        }

        #endregion

        private void Initialize()
        {
            Goto("konfigurator3d");
            MaximizeWindow();
        }
        public void Goto(string url, bool useBaseUrl = true)
        {
            if (useBaseUrl)
                Driver.Navigate().GoToUrl(string.Format("{0}/{1}", _baseUrl, url));
            else
                Driver.Navigate().GoToUrl(url);
        }
        public void MaximizeWindow()
        {
            Driver.Manage().Window.Maximize();
        }

        public void Quit()
        {
            Driver.Quit();
        }
        public enum DriverType
        {
            Chrome,
            Firefox,
            IE
        }

    }
}
