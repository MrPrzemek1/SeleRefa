using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Model;
using RawaTests.Model.Login;
using RawaTests.Services.Base;
using System;

namespace RawaTests.Services
{
    class LoginPageWCServices : BaseService
    {
        public LoginPageWCServices() : base()
        {

        }
        public LoginPageWCModel GetLoginPageModel()
        {
            System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));

            var CompanyName =Manager.FindWebElementAndWait(By.Name(LoginPageElementsLocators.CompanyInput));
            var Login = Manager.FindWebElement(By.Name(LoginPageElementsLocators.LoginInput));
            var Password = Manager.FindWebElement(By.Name(LoginPageElementsLocators.PasswordInput));
            var SubmitButton = Manager.FindWebElement(By.XPath(LoginPageElementsLocators.submitLogin));
            var ValidateField = Manager.FindWebElement(By.XPath(LoginPageElementsLocators.ValidateField));

            LoginPageWCModel model = new LoginPageWCModel(CompanyName, Login, Password, SubmitButton, ValidateField);
            System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));

            return model;
        }
    }
}


