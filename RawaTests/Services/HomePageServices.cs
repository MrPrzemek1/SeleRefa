using static RawaTests.Helpers.DriverHelper.DriverHelp;
using OpenQA.Selenium;
using RawaTests.Model;
using RawaTests.Helpers;
using RawaTests.Model.Home;
using RawaTests.Services.Base;
using RawaTests.Model.Base.Buttons;
using RawaTests.IWebElements.TextElements;
using RawaTests.IWebElements;

namespace RawaTests.Services
{
    class HomePageServices : BaseService
    {
        public HomePageModel GetHomePageModel()
        {
            var startButton = new NxButton(FindElement(By.XPath(HomePageElementsLocators.ButtonStart)));
            var homePageImage = new NxImage(FindElement(By.XPath(HomePageElementsLocators.HomePageImage)));
            var logoImage = new NxImage(FindElement(By.XPath(HomePageElementsLocators.HomePageLogo)));
            var footer = new NxLabels(FindElement(By.XPath(HomePageElementsLocators.Footer)));
            var loginBtn = new NxButton(FindElement(By.XPath(HomePageElementsLocators.LoginButton)));
            var header = new NxLabels(FindElement(By.XPath(HomePageElementsLocators.Header)));
            var logout = new NxLabels(FindElement(By.Id(HomePageElementsLocators.LogoutDiv)));

            HomePageModel homeModel = new HomePageModel(startButton, homePageImage, logoImage, footer, loginBtn, header, logout);

            return homeModel;
        }

    }
}
