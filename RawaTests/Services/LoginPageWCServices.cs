using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Model;
using RawaTests.Services.Base;
using RawaTests.WebElementsModels;
using System;

namespace RawaTests.Services
{
    class LoginPageWCServices : BaseService
    {
        public LoginPageWCServices() : base()
        {

        }
        public ActionOnWCLoginPage GetLoginPageModel()
        {
            System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));

            var CompanyName =new NxWEInputModel(Manager.FindWebElementAndWait(By.Name(LoginPageElementsLocators.CompanyInput)));
            var Login = new NxWEInputModel(Manager.FindWebElementWithoutWait(By.Name(LoginPageElementsLocators.LoginInput)));
            var Password = new NxWEInputModel(Manager.FindWebElementWithoutWait(By.Name(LoginPageElementsLocators.PasswordInput)));
            var SubmitButton = new NxWEButtonModel(Manager.FindWebElementWithoutWait(By.XPath(LoginPageElementsLocators.submitLogin)));
            var ValidateField = new NxWELabelModel(Manager.FindWebElementWithoutWait(By.XPath(LoginPageElementsLocators.ValidateField)));

            ActionOnWCLoginPage model = new ActionOnWCLoginPage(CompanyName, Login, Password, SubmitButton, ValidateField);
            System.Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.fff"));

            return model;
        }
    }
}


