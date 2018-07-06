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
            logger.Trace("HomePageModel will start build.");
            var startButton = _manager.FindWebElementAndWait(By.XPath(HomePageElementsLocators.startButtonLocator));
            var homePageImage = _manager.FindWebElement(By.ClassName(HomePageElementsLocators.homePageImageLocator));
            var logoImage = _manager.FindWebElement(By.XPath(HomePageElementsLocators.homePageLogoLocator));
            var footer = _manager.FindWebElement(By.XPath(HomePageElementsLocators.footerLocator));
            var loginButton = _manager.FindWebElement(By.XPath(HomePageElementsLocators.loginButtonLocator));
            var header = _manager.FindWebElement(By.XPath(HomePageElementsLocators.headerLocator));
            var logoutDiv = _manager.FindWebElement(By.Id(HomePageElementsLocators.logoutDivLocator));
            var logoutButton = logoutDiv.FindWebElement(By.TagName(HomePageElementsLocators.logoutButtonLocator));

            HomePageWCModel homeModel = new HomePageWCModel(_manager.Driver,startButton, homePageImage, logoImage, footer, loginButton, header, logoutDiv, logoutButton);

            return homeModel;
        }

    }
}
