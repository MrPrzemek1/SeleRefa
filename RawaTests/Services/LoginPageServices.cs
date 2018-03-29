using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Model;
using static TestyRawa.DriverHelper.Browser;

namespace RawaTests.Services
{
    class LoginPageServices
    {
        public LoginPageModel GetLoginPageModel()
        {
            LoginPageModel model = new LoginPageModel();

            model.CompanyName = Driver.FindElement(By.XPath(HtmlLoginPageElements.CompanyInput));
            model.Login = Driver.FindElement(By.XPath(HtmlLoginPageElements.LoginInput));
            model.Password = Driver.FindElement(By.XPath(HtmlLoginPageElements.PasswordInput));
            model.LoginButton = Driver.FindElement(By.XPath(HtmlLoginPageElements.ButtonLogin));
            model.ValidateField = Driver.FindElement(By.XPath(HtmlLoginPageElements.ValidateField));

            return model;
        }

    }
}

