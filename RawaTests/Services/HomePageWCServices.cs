using OpenQA.Selenium;
using RawaTests.Services.Base;
using RawaTests.Helpers;
using System;
using RawaTests.ContainersModels.Home;
using RawaTests;
namespace RawaTests.Services
{
    class HomePageWCServices : BaseService
    {
        public HomePageWCServices() : base()
        {

        }
        /// <summary>
        /// Metoda budująca model strony głównej.
        /// </summary>
        /// <returns></returns>
        public ActionOnWCHomePage GetHomePageModel()
        {
            System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));
            var startButton = Manager.FindWebElementAndWait(By.XPath(HomePageElementsLocators.ButtonStart));
            var homePageImage = Manager.FindWebElement(By.ClassName(HomePageElementsLocators.HomePageImage));
            var logoImage = Manager.FindWebElement(By.XPath(HomePageElementsLocators.HomePageLogo));
            var footer = Manager.FindWebElement(By.XPath(HomePageElementsLocators.Footer));
            var loginButton = Manager.FindWebElement(By.XPath(HomePageElementsLocators.LoginButton));
            var header = Manager.FindWebElement(By.XPath(HomePageElementsLocators.Header));
            var logoutDiv = Manager.FindWebElement(By.Id(HomePageElementsLocators.LogoutDiv));

            var logoutButton = logoutDiv.FindWebElement(By.TagName(HomePageElementsLocators.LogoutButton));

            System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));

            ActionOnWCHomePage homeModel = new ActionOnWCHomePage(startButton, homePageImage, logoImage, footer, loginButton, header, logoutDiv, logoutButton);

            return homeModel;
        }

    }
}
