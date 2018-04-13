using OpenQA.Selenium;
using RawaTests.Services.Base;
using RawaTests.Helpers;
using System;
using RawaTests.WebElementsModels;
using RawaTests.ContainersModels.Home;

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

            var startButton = new NxWEButtonModel(Manager.FindWebElementAndWait(By.XPath(HomePageElementsLocators.ButtonStart)));
            var homePageImage = new NxWEImageModel(Manager.FindWebElementWithoutWait(By.ClassName(HomePageElementsLocators.HomePageImage)));
            var logoImage = new NxWEImageModel(Manager.FindWebElementWithoutWait(By.XPath(HomePageElementsLocators.HomePageLogo)));
            var footer = new NxWELabelModel(Manager.FindWebElementWithoutWait(By.XPath(HomePageElementsLocators.Footer)));
            var loginButton = new NxWEButtonModel(Manager.FindWebElementWithoutWait(By.XPath(HomePageElementsLocators.LoginButton)));
            var header = new NxWELabelModel(Manager.FindWebElementWithoutWait(By.XPath(HomePageElementsLocators.Header)));
            var logoutDiv = new NxWELabelModel(Manager.FindWebElementWithoutWait(By.Id(HomePageElementsLocators.LogoutDiv)));
            var logoutButton = logoutDiv.FindElementAndWait<NxWEButtonModel>(By.TagName(HomePageElementsLocators.LogoutButton));
            System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));

            ActionOnWCHomePage homeModel = new ActionOnWCHomePage(startButton, homePageImage, logoImage, footer, loginButton, header, logoutDiv, logoutButton);

            return homeModel;
        }

    }
}
