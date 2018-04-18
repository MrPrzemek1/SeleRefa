using NUnit.Framework;
using RawaTests.Services;
using RawaTests.ValidateMessages;
using RawaTests.Model;

namespace RawaTests.Tests
{
    [TestFixture,Category("Rawa")]
    public class LoginPageTests : BaseTest
    {
        LoginPageWCServices loginServices;
        HomePageWCServices homeServices;

        public LoginPageTests()
        {
            loginServices = new LoginPageWCServices();
            homeServices = new HomePageWCServices();
        }

        [Test, Order(1)]
        public void CorrectLogin()
        {
            homeServices.GetHomePageModel().LoginBtn.Click();

            ActionOnWCLoginPage loginPage = loginServices.GetLoginPageModel();
            loginPage.SetCorrectLoginData();
            loginPage.SubmitButton.Click();
            HomePageWCModel homePageAfterLogin = homeServices.GetHomePageModel();
            Assert.IsTrue(homePageAfterLogin.LogoutDiv.Displayed);
            Assert.IsTrue(homePageAfterLogin.LogoutDiv.Text.Equals(ValidateTextsHelper.CorrectLoginText));
        }

        [Test, Order(2)]
        public void VerifyingValidateTextWhenCompanyNameIsEmpty()
        {
            homeServices.GetHomePageModel().LogoutButton.Click();
            Manager.Driver.SwitchTo().Alert().Accept();
            homeServices.GetHomePageModel().LoginBtn.Click();

            ActionOnWCLoginPage loginPage = loginServices.GetLoginPageModel();
            loginPage.LoginInput.SendKeys("Test");
            loginPage.PasswordInput.SendKeys("test");
            loginPage.SubmitButton.Click();
            ActionOnWCLoginPage loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateFieldIsDisplayed);
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.CompanyValidateText));
        }
        [Test, Order(3)]
        public void VerifingValidateTextWhenUserNameIsEmpty()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.Click();
            ActionOnWCLoginPage loginPage = loginServices.GetLoginPageModel();
            loginPage.CompanyNameInput.SendKeys("lalala");
            loginPage.PasswordInput.SendKeys("lalala");
            loginPage.SubmitButton.Click();
            ActionOnWCLoginPage loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.LoginValidateText));
        }
        [Test, Order(4)]
        public void VerifingValidateTextPasswordFieldIsEmpty()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.Click();
            ActionOnWCLoginPage loginPage = loginServices.GetLoginPageModel();
            loginPage.CompanyNameInput.SendKeys("lalala");
            loginPage.LoginInput.SendKeys("lalala");
            loginPage.SubmitButton.Click();
            ActionOnWCLoginPage loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.PasswordValidateText));
        }
        [Test, Order(5)]
        public void VerifingValidateTextWhenLoginDataWasIncorrect()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.Click();
            ActionOnWCLoginPage loginPage = loginServices.GetLoginPageModel();
            loginPage.SetLoginData("Test","Test","Test");
            loginPage.SubmitButton.Click();
            ActionOnWCLoginPage loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.ErrorValidateText));
        }

    }
}
