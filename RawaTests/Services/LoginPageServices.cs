using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Model;
using RawaTests.Model.Base.Buttons;
using RawaTests.Model.Home;
using RawaTests.Model.Login;
using RawaTests.Services.Base;
using static TestyRawa.DriverHelper.Browser;

namespace RawaTests.Services
{
    class LoginPageServices : BaseService
    {

        //public LoginPageModel GetLoginPageModel()
        //{
        //    var CompanyName = FindElement(By.XPath(HtmlLoginPageElements.CompanyInput));
        //    var Login = FindElementFor(By.XPath(HtmlLoginPageElements.LoginInput));
        //    var Password = FindElementFor(By.XPath(HtmlLoginPageElements.PasswordInput));
        //    var LoginButtonElement = FindElementFor(By.XPath(HtmlLoginPageElements.ButtonLogin));
        //    var LoginButton = new NxButton(LoginButtonElement);
        //    var ValidateField = FindElementFor(By.XPath(HtmlLoginPageElements.ValidateField));
        //    LoginPageModel model = new LoginPageModel(CompanyName, Login, Password, LoginButton, LoginButtonElement, ValidateField);
        //    return model;
        //}         
    }
}


