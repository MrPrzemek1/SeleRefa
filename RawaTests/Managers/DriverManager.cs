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

        public IWebElement FindWebElementAndWait(By by)
        {
            var find = FindWebElementsAndWait(by);
            if (find == null)
            {
                return null;
            }
            else
                return find.FirstOrDefault();
        }
        public IList<IWebElement> FindWebElementsAndWait(By by, int second = 2)
        {
            return DriverHelper.FindWebElementsAndWait(Driver, by, second);
        }

        public IWebElement FindWebElementAndWait(IWebElement e, By by)
        {
            var find = FindWebElementsAndWait(e, by);
            if (find == null)
            {
                return null;
            }
            else
                return find.FirstOrDefault();
        }
        public IList<IWebElement> FindWebElementsAndWait(IWebElement e, By by, int second = 2)
        {
            return DriverHelper.FindWebElementsAndWait(Driver, e, by, second);
        }

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
