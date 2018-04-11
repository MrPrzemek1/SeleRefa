﻿using OpenQA.Selenium;
using static RawaTests.Helpers.WebElementHelper;
using RawaTests.Model.Home;
using RawaTests.Services.Base;
using RawaTests.Model.Base.Buttons;
using RawaTests.IWebElements.TextElements;
using RawaTests.IWebElements;
using RawaTests.Helpers.DriverHelper;
using RawaTests.Helpers;
using System;

namespace RawaTests.Services
{
    class HomePageServices : BaseService
    {
        public HomePageServices() : base()
        {

        }

        public HomePageModel GetHomePageModel()
        {
            System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));
            Manager.Wait(By.XPath(HomePageElementsLocators.ButtonStart));

            var startButton = new NxButton(Manager.FindWebElementWithoutWait(By.XPath(HomePageElementsLocators.ButtonStart)));
            var homePageImage = new NxImage(Manager.FindWebElementWithoutWait(By.ClassName(HomePageElementsLocators.HomePageImage)));
            var logoImage = new NxImage(Manager.FindWebElementWithoutWait(By.XPath(HomePageElementsLocators.HomePageLogo)));
            var footer = new NxLabels(Manager.FindWebElementWithoutWait(By.XPath(HomePageElementsLocators.Footer)));
            var loginButton = new NxButton(Manager.FindWebElementWithoutWait(By.XPath(HomePageElementsLocators.LoginButton)));
            var header = new NxLabels(Manager.FindWebElementWithoutWait(By.XPath(HomePageElementsLocators.Header)));
            var logoutDiv = new NxLabels(Manager.FindWebElementWithoutWait(By.Id(HomePageElementsLocators.LogoutDiv)));
            var logoutButton = logoutDiv.FindElementAndWait<NxButton>(By.TagName(HomePageElementsLocators.LogoutButton));
            System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));

            HomePageModel homeModel = new HomePageModel(startButton, homePageImage, logoImage, footer, loginButton, header, logoutDiv, logoutButton); //startButton, homePageImage, logoImage, footer, header, logoutDiv, logoutButton

            return homeModel;
        }

    }
}
