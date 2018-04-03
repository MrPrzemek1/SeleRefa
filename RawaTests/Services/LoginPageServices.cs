using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.IWebElements.TextElements;
using RawaTests.Model;
using RawaTests.Model.Base.Buttons;
using RawaTests.Model.Home;
using RawaTests.Model.Login;
using RawaTests.Services.Base;
using RawaTests.WebElements.Input;
using RawaTests.WebElements.TextElements;
using static RawaTests.Helpers.DriverHelper.DriverHelp;

namespace RawaTests.Services
{
    class LoginPageServices : BaseService
    {

        public LoginPageModel GetLoginPageModel()
        {
            var CompanyName =new NxInput(FindElement(By.XPath(LoginPageElementsLocators.CompanyInput)));
            var Login = new NxInput(FindElement(By.XPath(LoginPageElementsLocators.LoginInput)));
            var Password = new NxInput(FindElement(By.XPath(LoginPageElementsLocators.PasswordInput)));
            var SubmitButton = new NxButton(FindElement(By.XPath(LoginPageElementsLocators.submitLogin)));
            var ValidateField = new NxWebText(FindElement(By.XPath(LoginPageElementsLocators.ValidateField)));

            LoginPageModel model = new LoginPageModel(CompanyName, Login, Password, SubmitButton, ValidateField);
            return model;
        }
    }
}


