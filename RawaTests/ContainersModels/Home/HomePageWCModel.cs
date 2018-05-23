using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base;

namespace RawaTests.Model
{
    public class HomePageWCModel : BaseWebContainerModel
    {
        private IWebDriver _driver;
        public IWebElement startButton { get; set; }
        public IWebElement homePageImage { get; set; }
        public IWebElement logoImage { get; set; }
        public IWebElement footer { get; set;}
        public IWebElement loginButton { get; set; }
        public IWebElement header { get; set; }
        public IWebElement logoutDiv { get; set; }
        public IWebElement logoutButton { get; set; }
    

        public HomePageWCModel(IWebDriver driver, IWebElement startBtn, IWebElement homeImg, IWebElement logoImg, IWebElement footer, IWebElement loginBtn, IWebElement header, IWebElement logoutDiv, IWebElement logoutBtn)
        {
            this._driver = driver;
            startButton = startBtn;
            homePageImage = homeImg;
            logoImage = logoImg;
            this.footer = footer;
            loginButton = loginBtn;
            this.header = header;
            this.logoutDiv = logoutDiv;
            logoutButton = logoutBtn;
        }
        //Metoda sprawdzająca czy strona glowna sie poprawnie zaladowala
        public override bool IsValid() => startButton.Displayed && homePageImage.GetAttributeSrc() != null && footer.Text.Equals(Configurator3DConsts.FOOTER) && header.Text.Equals(Configurator3DConsts.HEADER);
        // Metoda przechodząca do formularza logowania.
        public void GotoLoginPage() => loginButton.ClickIfElementIsClickable(_driver);     
    }
}
