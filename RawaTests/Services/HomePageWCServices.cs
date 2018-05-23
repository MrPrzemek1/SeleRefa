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
            var startButton = Manager.FindWebElementAndWait(By.XPath(HomePageElementsLocators.StartButtonLocator));
            var homePageImage = Manager.FindWebElement(By.ClassName(HomePageElementsLocators.HomePageImageLocator));
            var logoImage = Manager.FindWebElement(By.XPath(HomePageElementsLocators.HomePageLogoLocator));
            var footer = Manager.FindWebElement(By.XPath(HomePageElementsLocators.FooterLocator));
            var loginButton = Manager.FindWebElement(By.XPath(HomePageElementsLocators.LoginButtonLocator));
            var header = Manager.FindWebElement(By.XPath(HomePageElementsLocators.HeaderLocator));
            var logoutDiv = Manager.FindWebElement(By.Id(HomePageElementsLocators.LogoutDivLocator));
            var logoutButton = logoutDiv.FindWebElement(By.TagName(HomePageElementsLocators.LogoutButtonLocator));

            HomePageWCModel homeModel = new HomePageWCModel(Manager.Driver,startButton, homePageImage, logoImage, footer, loginButton, header, logoutDiv, logoutButton);

            return homeModel;
        }

    }
}
