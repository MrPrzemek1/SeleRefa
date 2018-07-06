using NLog;
using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base;

namespace RawaTests.Model
{
    public class HomePageWCModel : BaseWebContainerModel
    {
        private IWebDriver _driver;
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public IWebElement StartButton { get; set; }
        public IWebElement HomePageImage { get; set; }
        public IWebElement LogoImage { get; set; }
        public IWebElement Footer { get; set;}
        public IWebElement LoginButton { get; set; }
        public IWebElement Header { get; set; }
        public IWebElement LogoutDiv { get; set; }
        public IWebElement LogoutButton { get; set; }

        public HomePageWCModel(IWebDriver driver, IWebElement startBtn, IWebElement homeImg, IWebElement logoImg, IWebElement footer, IWebElement loginBtn, IWebElement header, IWebElement logoutDiv, IWebElement logoutBtn)
        {
            _driver = driver;
            StartButton = startBtn;
            HomePageImage = homeImg;
            LogoImage = logoImg;
            Footer = footer;
            LoginButton = loginBtn;
            Header = header;
            LogoutDiv = logoutDiv;
            LogoutButton = logoutBtn;
        }
        //Metoda sprawdzająca czy strona glowna sie poprawnie zaladowala
        public override bool IsValid() => StartButton.Displayed && HomePageImage.GetAttributeSrc() != null && Footer.Text.Equals(Configurator3DConsts.FOOTER) && Header.Text.Equals(Configurator3DConsts.HEADER);
        // Metoda przechodząca do formularza logowania.
        public void GotoLoginPage()
        {
            LoginButton.ClickIfElementIsClickable(_driver);
            _logger.Info("LoginPage");
        }
    }
}
