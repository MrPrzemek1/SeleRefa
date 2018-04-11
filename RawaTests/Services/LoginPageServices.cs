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
using System;
using static RawaTests.Helpers.DriverHelper.DriverHelper;

namespace RawaTests.Services
{
    class LoginPageServices : BaseService
    {
        public LoginPageServices() : base()
        {

        }
        public LoginPageModel GetLoginPageModel()
        {
            System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));

            var CompanyName =new NxInput(Manager.FindWebElementAndWait(By.XPath(LoginPageElementsLocators.CompanyInput)));
            var Login = new NxInput(Manager.FindWebElementWithoutWait(By.XPath(LoginPageElementsLocators.LoginInput)));
            var Password = new NxInput(Manager.FindWebElementWithoutWait(By.XPath(LoginPageElementsLocators.PasswordInput)));
            var SubmitButton = new NxButton(Manager.FindWebElementWithoutWait(By.XPath(LoginPageElementsLocators.submitLogin)));
            var ValidateField = new NxLabels(Manager.FindWebElementWithoutWait(By.XPath(LoginPageElementsLocators.ValidateField)));

            LoginPageModel model = new LoginPageModel(CompanyName, Login, Password, SubmitButton, ValidateField);
            System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));

            return model;
        }
    }
}


