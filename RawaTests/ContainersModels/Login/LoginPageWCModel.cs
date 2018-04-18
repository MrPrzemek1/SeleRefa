using OpenQA.Selenium;
using RawaTests.Model.Base;

namespace RawaTests.Model.Login
{
    abstract class LoginPageWCModel : BaseWebContainerModel
    {
        public IWebElement CompanyNameInput { get; set; }
        public IWebElement LoginInput { get; set; }
        public IWebElement PasswordInput { get; set; }
        public IWebElement SubmitButton { get; set; }
        public IWebElement ValidateFieldElement { get; set; }
    }

}
