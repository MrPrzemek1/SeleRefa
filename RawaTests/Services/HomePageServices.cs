using OpenQA.Selenium;
using static RawaTests.Helpers.WebElementHelper;
using RawaTests.Model.Home;
using RawaTests.Services.Base;
using RawaTests.Model.Base.Buttons;
using RawaTests.IWebElements.TextElements;
using RawaTests.IWebElements;
using RawaTests.Helpers.DriverHelper;
using RawaTests.Helpers;

namespace RawaTests.Services
{
    class HomePageServices : BaseService
    {
        public HomePageServices() : base()
        {

        }

        public HomePageModel GetHomePageModel()
        {
            
            var startButton = new NxButton(Manager.FindWebElementAndWait(By.XPath(HomePageElementsLocators.ButtonStart)));
            var homePageImage = new NxImage(Manager.FindWebElementAndWait(By.ClassName(HomePageElementsLocators.HomePageImage)));
            var logoImage = new NxImage(Manager.FindWebElementAndWait(By.XPath(HomePageElementsLocators.HomePageLogo)));
            var footer = new NxLabels(Manager.FindWebElementAndWait(By.XPath(HomePageElementsLocators.Footer)));
            var loginBtn = new NxButton(Manager.FindWebElementAndWait(By.XPath(HomePageElementsLocators.LoginButton)));
            var header = new NxLabels(Manager.FindWebElementAndWait(By.XPath(HomePageElementsLocators.Header)));
            var logout = new NxLabels(Manager.FindWebElementAndWait(By.Id(HomePageElementsLocators.LogoutDiv)));

            HomePageModel homeModel = new HomePageModel(startButton, homePageImage, logoImage, footer, loginBtn, header, logout); 

            return homeModel;
        }

    }
}
