using NUnit.Framework;
using RawaTests.Services;
using RawaTests.ValidateMessages;
using RawaTests.Tests;
using RawaTests.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using RawaTests.Model.Home;
using RawaTests.Model.StepTwo;
using RawaTests.StepOne;

namespace RawaTests.Tests
{
    [TestFixture,Category("Rawa")]
    public class LoginPageTests : BaseTest
    {
        LoginPageServices loginServices;
        HomePageServices homeServices;

        public LoginPageTests()
        {
            loginServices = new LoginPageServices();
            homeServices = new HomePageServices();
        }

        [Test, Order(1)]
        public void CorrectLogin()
        {
            homeServices.GetHomePageModel().LoginBtn.Click();

            LoginPageModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetCorrectLoginData();
            loginPage.SubmitButton.Click();
            HomePageModel homePageAfterLogin = homeServices.GetHomePageModel();
            Assert.IsTrue(homePageAfterLogin.LogoutDiv.Dispalyed());
            Assert.IsTrue(homePageAfterLogin.LogoutDiv.Text.Equals(ValidateTextsHelper.CorrectLoginText));
        }

        [Test, Order(2)]
        public void VerifyingValidateTextWhenCompanyNameIsEmpty()
        {
            homeServices.GetHomePageModel().LogoutButton.Click();
            Manager.Driver.SwitchTo().Alert().Accept();
            homeServices.GetHomePageModel().LoginBtn.Click();

            LoginPageModel loginPage = loginServices.GetLoginPageModel();
            loginPage.LoginInput.SendText("Test");
            loginPage.PasswordInput.SendText("test");
            loginPage.SubmitButton.Click();
            LoginPageModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateFieldIsDisplayed);
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.CompanyValidateText));
        }
        [Test, Order(3)]
        public void VerifingValidateTextWhenUserNameIsEmpty()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.Click();
            LoginPageModel loginPage = loginServices.GetLoginPageModel();
            loginPage.CompanyNameInput.SendText("lalala");
            loginPage.PasswordInput.SendText("lalala");
            loginPage.SubmitButton.Click();
            LoginPageModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.LoginValidateText));
        }
        [Test, Order(4)]
        public void VerifingValidateTextPasswordFieldIsEmpty()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.Click();
            LoginPageModel loginPage = loginServices.GetLoginPageModel();
            loginPage.CompanyNameInput.SendText("lalala");
            loginPage.LoginInput.SendText("lalala");
            loginPage.SubmitButton.Click();
            LoginPageModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.PasswordValidateText));
        }
        [Test, Order(5)]
        public void VerifingValidateTextWhenLoginDataWasIncorrect()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.Click();
            LoginPageModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetLoginData("Test","Test","Test");
            loginPage.SubmitButton.Click();
            LoginPageModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.ErrorValidateText));
        }

    }
}
