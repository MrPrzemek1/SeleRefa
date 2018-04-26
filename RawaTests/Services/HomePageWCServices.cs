using OpenQA.Selenium;
using RawaTests.Services.Base;
using RawaTests.Helpers;
using RawaTests.Model;
using RawaTests.Managers;

namespace RawaTests.Services
{
    class HomePageWCServices : BaseService
    {
        private DriverManager Manager;
        public HomePageWCServices(DriverManager manager) : base(manager)
        {
            Manager = manager;
        }
        /// <summary>
        /// Metoda budująca model strony głównej.
        /// </summary>
        /// <returns></returns>
        public HomePageWCModel GetHomePageModel()
        {
            var startButton = Manager.FindWebElementAndWait(By.XPath(HomePageElementsLocators.ButtonStart));
            var homePageImage = Manager.FindWebElement(By.ClassName(HomePageElementsLocators.HomePageImage));
            var logoImage = Manager.FindWebElement(By.XPath(HomePageElementsLocators.HomePageLogo));
            var footer = Manager.FindWebElement(By.XPath(HomePageElementsLocators.Footer));
            var loginButton = Manager.FindWebElement(By.XPath(HomePageElementsLocators.LoginButton));
            var header = Manager.FindWebElement(By.XPath(HomePageElementsLocators.Header));
            var logoutDiv = Manager.FindWebElement(By.Id(HomePageElementsLocators.LogoutDiv));

            var logoutButton = logoutDiv.FindWebElement(By.TagName(HomePageElementsLocators.LogoutButton));

            HomePageWCModel homeModel = new HomePageWCModel(startButton, homePageImage, logoImage, footer, loginButton, header, logoutDiv, logoutButton);

            return homeModel;
        }

    }
}
