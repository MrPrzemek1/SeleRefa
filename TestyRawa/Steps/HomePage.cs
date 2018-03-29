using OpenQA.Selenium;
namespace TestyRawa
{
    class HomePage
    {
        IWebDriver driver { get { return DriverHelper.Browser.Driver; } }
        private IWebElement StartButton => driver.FindElement(By.XPath("//button[@class='btn btn-primary btn-lg btn-start']"));
        private IWebElement HomePageImg => driver.FindElement(By.XPath("//img[@class=' img-responsive']"));
        private IWebElement HomePageLogoImg => driver.FindElement(By.ClassName("logo"));
        private IWebElement Footer => driver.FindElement(By.XPath("//div[@class=' col-xs-12 footer-wraper']"));
        private IWebElement LoginButton => driver.FindElement(By.XPath("//a[@class='link-login']"));
        private IWebElement UserLoggedInfo => driver.FindElement(By.XPath("//button[contains(text(),'Wyloguj')]"));
        private string PageTitle => driver.Title;
        /// <summary>
        /// Metoda sprawdzająca czy obrazek główny wyświeta się na stronie. Najpierw sprawdzany jest czy zawartość pola img jest równa null jeżeli nie to sprawdzane jest czy link do obrazka jest poprawny.
        /// </summary>
        /// <returns>
        /// ture - jezeli link jest oraz jest poprawny
        /// false - jezeli obrazka nie ma lub jest niepoprawny.
        /// </returns>
        public bool HomePageImgIsPresentOnPage()
        {
            string XLHomePageImgLink = "http://roger.netrix.com.pl:96/Handlers/XlImageHandler.ashx?id=1129&compression=0&extension=jpg";
            var HomePageImgScr = HomePageImg.GetAttribute("src");

            if (HomePageImgScr == null)
            {
                return false;
            }
            else
                if (HomePageImgScr.Equals(XLHomePageImgLink))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Metoda sprawdzająca czy logo wyświeta się na stronie. Najpierw sprawdzany jest czy zawartość pola img jest równa null jeżeli nie to sprawdzane jest czy link do obrazka jest poprawny.
        /// </summary>
        /// <returns>
        /// ture - jezeli link jest oraz jest poprawny
        /// false - jezeli obrazka nie ma lub jest niepoprawny.
        /// </returns>
        public bool HomePageLogoImgIsPresentOnPage()
        {
            string XLHomePageLogoImgLink = "http://roger.netrix.com.pl:96/Handlers/XlImageHandler.ashx?id=22&compression=0&extension=png";
            var HomePageLogoImgSrc = HomePageLogoImg.GetAttribute("src");
            if (HomePageLogoImgSrc == null)
            {
                return false;
            }
            else
                if (HomePageLogoImgSrc.Equals(XLHomePageLogoImgLink))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Metoda zwracająca napis na przycisku "Start"
        /// </summary>
        /// <returns>string - napis przycisku "Start"</returns>
        public string GetStartButtonText()
        {
            return StartButton.Text;
        }
        /// <summary>
        /// Metoda sprawdzająca czy przycisk start pojawił się na stronie.a
        /// </summary>
        /// <returns>
        ///     true - jeżeli przycisk pojawił sie na stronie
        ///     false - jezeli przycisk nie pojawił się na stronie
        /// </returns>
        public bool StartButtonIsDisplayed()
        {
            if (StartButton.Displayed)
            {
                return true;
            }
            else
                return false;
        }
        public string GetFooterText()
        {
            return Footer.Text;
        }
        public void GoToLoginPage()
        {
            LoginButton.Click();
        }
    }
}
