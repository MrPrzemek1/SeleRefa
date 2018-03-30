using static TestyRawa.DriverHelper.Browser;
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
            var startButton = new NxButton();
            var homePageImage = new NxWebImage();
            var logoImage = new NxWebImage();
            var footer = new NxWebText();
            var loginBtn = new NxButton();
            HomePageModel homeModel = new HomePageModel(startButton, homePageImage, logoImage, footer, loginBtn);

            return homeModel;
        }
    }
}
