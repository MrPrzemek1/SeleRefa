﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using RawaTests.Helpers.DriverHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace RawaTests.Managers
{
    public class DriverManager
    {
        private const string _baseUrl = "http://demo.net-art.eu/";

        public DriverType Type { get; private set; }

        public DriverManager(DriverType type)
        {
            Type = type;
            Driver = GetDriver(type);
        }
       
        public IWebDriver Driver { get; private set; }

        public string Title { get { return Driver.Title; } }

        public IWebDriver GetDriver(DriverType driver)
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
                //case DriverType.IE:
                //    InternetExplorerOptions optionsIE = new InternetExplorerOptions();
                //    optionsIE.IgnoreZoomLevel = true;
                //    optionsIE.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                //    optionsIE.RequireWindowFocus = true;
                //    return new InternetExplorerDriver(optionsIE);
                //case DriverType.Opera:
                //    OperaOptions operaOptions = new OperaOptions();
                //    operaOptions.BinaryLocation = @"E:\GitHub\SeleRefa\RawaTests\bin\Debug";
                //    //operaOptions.ToCapabilities();
                //    return new OperaDriver(@"E:\GitHub\SeleRefa\RawaTests\bin\Debug", operaOptions);
                default:
                    throw new ArgumentOutOfRangeException("Przeglądarka nie jest obslugiwana");
            }
        }
        #region Wyszukiwanie i czekanie na elementy.
        public IWebElement FindWebElementAndWait(By by) => DriverHelper.FindWebElementAndWait(Driver, by);

        public IList<IWebElement> FindWebElementsAndWait(By by) => DriverHelper.FindWebElementsAndWait(Driver, by);
        #endregion

        #region Wyszukiwanie elementów bez czekania na nie
        public IWebElement FindWebElement(By by) => DriverHelper.FindWebElementWithoutWait(Driver, by);
       
        public IList<IWebElement> FindWebElements(By by) => DriverHelper.FindWebElementsWithoutWait(Driver, by);
        #endregion

        public void Initialize()
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
        public void MaximizeWindow() => Driver.Manage().Window.Maximize();

        public void Quit() => Driver.Quit();

        public void AcceptAlert() => Driver.SwitchTo().Alert().Accept();

    }
}
