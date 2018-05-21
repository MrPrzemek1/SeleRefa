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

            var CompanyName =Manager.FindWebElementAndWait(By.Name(LoginPageElementsLocators.CompanyInput));
            var Login = Manager.FindWebElement(By.Name(LoginPageElementsLocators.LoginInput));
            var Password = Manager.FindWebElement(By.Name(LoginPageElementsLocators.PasswordInput));
            var SubmitButton = Manager.FindWebElement(By.XPath(LoginPageElementsLocators.submitLogin));
            var ValidateField = Manager.FindWebElement(By.XPath(LoginPageElementsLocators.ValidateField));

            LoginPageWCModel model = new LoginPageWCModel(Manager.Driver,CompanyName, Login, Password, SubmitButton, ValidateField);
            System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));

            return model;
        }
    }
}


