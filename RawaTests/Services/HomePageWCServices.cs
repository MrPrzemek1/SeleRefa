using OpenQA.Selenium;
using RawaTests.Services.Base;
using RawaTests.Helpers;
using RawaTests.Model;
using RawaTests.Managers;

namespace RawaTests.Services
{
    class HomePageWCServices : BaseService
    {
        public HomePageWCServices(DriverManager manager) : base(manager) { }

        /// <summary>
        /// Metoda budująca model strony głównej.
        /// </summary>
        /// <returns></returns>
        public HomePageWCModel GetHomePageModel()
        {
            var startButton = Manager.FindWebElementAndWait(By.XPath(HomePageElementsLocators.startButtonLocator));
            var homePageImage = Manager.FindWebElement(By.ClassName(HomePageElementsLocators.homePageImageLocator));
            var logoImage = Manager.FindWebElement(By.XPath(HomePageElementsLocators.homePageLogoLocator));
            var footer = Manager.FindWebElement(By.XPath(HomePageElementsLocators.footerLocator));
            var loginButton = Manager.FindWebElement(By.XPath(HomePageElementsLocators.loginButtonLocator));
            var header = Manager.FindWebElement(By.XPath(HomePageElementsLocators.headerLocator));
            var logoutDiv = Manager.FindWebElement(By.Id(HomePageElementsLocators.logoutDivLocator));
            var logoutButton = logoutDiv.FindWebElement(By.TagName(HomePageElementsLocators.logoutButtonLocator));

            HomePageWCModel homeModel = new HomePageWCModel(Manager.Driver,startButton, homePageImage, logoImage, footer, loginButton, header, logoutDiv, logoutButton);

            return homeModel;
        }

    }
}
