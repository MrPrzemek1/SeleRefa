using NUnit.Framework;
using RawaTests.Services;
using RawaTests.ValidateMessages;
using RawaTests.Tests.Base;
using RawaTests.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests.Tests
{
    [TestFixture(Category ="LoginPageTests")]
    public class LoginPageTests : BaseTest
    {
        LoginPageServices loginServices;
        HomePageServices homeServices;

        public LoginPageTests()
        {
            loginServices = new LoginPageServices();
            homeServices = new HomePageServices();
        }
        [SetUp]
        public void SetUp()
        {
            homeServices.GetHomePageModel().LoginBtn.Click();

        }
        [Test,Description("asdas"), Order(1)]
        public void CorrectLogin()
        {
            LoginPageModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetCorrectLoginData();
            loginPage.SubmitButton.Click();
            Assert.IsTrue(homeServices.GetHomePageModel().LogoutDiv.Contains(ValidateTextsHelper.LoginText));
            var a = homeServices.GetHomePageModel();
            a.LogoutButton.Click();
            Manager.Driver.SwitchTo().Alert().Accept();
            //Assert.IsFalse(a.LogoutDiv.Dispalyed());
        }

        [Test, Order(2)]
        public void VerifyingCompanyValidateTexts()
        {
            Manager.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            var a = Manager.Driver.FindElement(By.XPath("//div[@class='col-xs-12 div-login']"));
            var dd = a.FindElement(By.ClassName("link-login"));
            dd.Click();
            Manager.Driver.FindElement(By.Name("company")).SendKeys("rmg");
            Manager.Driver.FindElement(By.Name("username")).SendKeys("Radosław Gierach");
            Manager.Driver.FindElement(By.Name("password")).SendKeys("MADZIAZZ");
            Manager.Driver.FindElement(By.XPath("//input[@class='btn btn-primary btn-lg btn-login']")).Click();
            WebDriverWait wait = new WebDriverWait(Manager.Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("div-logout")));
            var b = Manager.Driver.FindElement(By.ClassName("div-logout"));
            var c = b.FindElement(By.TagName("Button"));
            c.Click();
            Manager.Driver.SwitchTo().Alert().Accept();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='btn btn-primary btn-lg btn-start']")));
            Assert.IsTrue(Manager.Driver.FindElement(By.ClassName("link-login")).Displayed);

        }
        [Test]
        public void VerifingValidateTextWhenAllLoginDataFieldAreEmpty()
        {
            
        }
        [Test]
        public void VerifyWrongLoginDataValidationText()
        {
            
        }
    }
}
