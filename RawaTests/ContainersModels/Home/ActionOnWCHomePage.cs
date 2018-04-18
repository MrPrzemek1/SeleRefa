using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model;
using RawaTests;

namespace RawaTests.ContainersModels.Home
{
    class ActionOnWCHomePage : HomePageWCModel
    {
        public ActionOnWCHomePage(IWebElement startBtn, IWebElement homeImg, IWebElement logoImg, IWebElement footer, IWebElement loginBtn, IWebElement header, IWebElement logoutDiv, IWebElement logoutBtn)
        {
            StartButton = startBtn;
            HomePageImage = homeImg;
            LogoImage = logoImg;
            Footer = footer;
            LoginBtn = loginBtn;
            Header = header;
            LogoutDiv = logoutDiv;
            LogoutButton = logoutBtn;
        }
        public override bool IsValid()
        {
            return StartButton.Displayed && HomePageImage.GetAttributeSrc() != null && Footer.Text.Equals(FooterAndHeaderConsts.FOOTER) && Header.Text.Equals(FooterAndHeaderConsts.HEADER);
        }
    }
}
