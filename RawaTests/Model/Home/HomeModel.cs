using OpenQA.Selenium;

namespace RawaTests.Model
{
    public class HomeModel
    {
        public IWebElement StartButton { get; set; }

        public IWebElement HomePageImage { get; set; }

        public IWebElement LogoImage { get; set; }

        public IWebElement Footer { get; set;}

        public IWebElement LoginBtn { get; set; }
    }
}
