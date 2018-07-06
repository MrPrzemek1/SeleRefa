using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Managers;
using RawaTests.Model.Login;
using RawaTests.Services.Base;
using System;

namespace RawaTests.Services
{
    class LoginPageWCServices : BaseService
    {
        public LoginPageWCServices(DriverManager manager) : base(manager) { }

        public LoginPageWCModel GetLoginPageModel()
        {
            System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));

            var CompanyName =_manager.FindWebElementAndWait(By.Name(LoginPageElementsLocators.companyInputLocator));
            var Login = _manager.FindWebElement(By.Name(LoginPageElementsLocators.loginInputLocator));
            var Password = _manager.FindWebElement(By.Name(LoginPageElementsLocators.passwordInputLocator));
            var SubmitButton = _manager.FindWebElement(By.XPath(LoginPageElementsLocators.submitLoginLocator));
            var ValidateField = _manager.FindWebElement(By.XPath(LoginPageElementsLocators.validateFieldLocator));

            LoginPageWCModel model = new LoginPageWCModel(_manager.Driver,CompanyName, Login, Password, SubmitButton, ValidateField);
            System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));

            return model;
        }
    }
}


