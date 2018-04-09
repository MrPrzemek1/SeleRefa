using OpenQA.Selenium;
using static RawaTests.Helpers.WebElementHelper;
using RawaTests.Model.Home;
using RawaTests.Services.Base;
using RawaTests.Model.Base.Buttons;
using RawaTests.IWebElements.TextElements;
using RawaTests.IWebElements;
using RawaTests.Helpers.DriverHelper;
using static RawaTests.Helpers.DriverHelper.DriverHelp;
using RawaTests.Helpers;

namespace RawaTests.Services
{
    class HomePageServices : BaseService
    {
        public HomePageModel GetHomePageModel()
        {
            var startButton = new NxButton(Driver By.XPath(HomePageElementsLocators.ButtonStart));
            var homePageImage = new NxImage(FindWebElement(By.ClassName(HomePageElementsLocators.HomePageImage)));
            var logoImage = new NxImage(FindWebElement(By.XPath(HomePageElementsLocators.HomePageLogo)));
            var footer = new NxLabels(FindElement(By.XPath(HomePageElementsLocators.Footer)));
            var loginBtn = new NxButton(FindElement(By.XPath(HomePageElementsLocators.LoginButton)));
            var header = new NxLabels(FindElement(By.XPath(HomePageElementsLocators.Header)));
            // var logout = new NxLabels(FindElement(By.Id(HomePageElementsLocators.LogoutDiv)));

            HomePageModel homeModel = new HomePageModel(startButton, homePageImage, logoImage, footer, loginBtn, header); // logout

            return homeModel;
        }

    }
}
