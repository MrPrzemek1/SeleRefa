using static TestyRawa.DriverHelper.Browser;
using OpenQA.Selenium;
using RawaTests.Model;
using RawaTests.Helpers;
using RawaTests.Model.Home;

namespace RawaTests.Services
{
    class HomePageServices
    {
        public HomePageModel GetHomePageModel()
        {
            HomePageModel homeModel = new HomePageModel();

            homeModel.StartButton = Driver.FindElement(By.XPath(HtmlHomePageElements.ButtonStart));
            homeModel.HomePageImage = Driver.FindElement(By.ClassName(HtmlHomePageElements.HomePageImage));
            homeModel.LogoImage = Driver.FindElement(By.ClassName(HtmlHomePageElements.HomePageLogo));
            homeModel.Footer = Driver.FindElement(By.XPath(HtmlHomePageElements.Footer));
            homeModel.LoginBtn = Driver.FindElement(By.XPath(HtmlHomePageElements.LoginButton));

            return homeModel;
        }
    }
}
