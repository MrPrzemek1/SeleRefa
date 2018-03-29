using NUnit.Framework;
using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Services;
using static TestyRawa.DriverHelper;
using static TestyRawa.DriverHelper.Browser;
using RawaTests.ValidateMessages;
namespace RawaTests.Tests
{
    [TestFixture(Category ="LoginPageTests")]
    public class LoginPageTests
    {
        LoginPageServices loginServices;
        HomePageServices homeSrv;

        public LoginPageTests()
        {
            loginServices = new LoginPageServices();
            homeSrv = new HomePageServices();
        }

        [OneTimeSetUp]
        public void TestInizialize()
        {
            Browser.Initialize();
            Driver.FindElement(By.XPath(HtmlHomePageElements.LoginButton)).Click();
            WaitUntilElementIsDisplayed(By.XPath(HtmlLoginPageElements.LoginForm),5);
        }

        [OneTimeTearDown]
        public void EndTest()
        {
            Browser.Quit();
        }

        [Test,Description("asdas"), Order(1)]
        public void CorrectLogin()
        {
            var LoginFormModel = loginServices.GetLoginPageModel();
            loginServices.SetLoginData(LoginFormModel);
            LoginFormModel.LoginButton.Click();
            WaitUntilElementIsDisplayed(By.XPath(HtmlHomePageElements.ButtonStart), 5);
            Assert.IsTrue(Driver.FindElement(By.XPath(HtmlLoginPageElements.LogoutButton)).Displayed);
        }

        [Test, Order(2)]
        public void VerifyingCompanyValidateTexts()
        {
            Driver.FindElement(By.XPath(HtmlLoginPageElements.LogoutButton)).Click();
            AlertHelper.AcceptAlert();
            WaitUntilElementIsDisplayed(By.XPath(HtmlHomePageElements.ButtonStart), 5);
            var homePageModel = homeSrv.GetHomePageModel();
            homeSrv.ClickOnLoginButton(homePageModel);
            var LoginFormModel = loginServices.GetLoginPageModel();
            LoginFormModel.Login.SendKeys(LoginData.Login);
            LoginFormModel.Password.SendKeys(LoginData.Password);
            LoginFormModel.LoginButton.Click();
        }

        [Test]
        public void VerifingValidateTextWhenAllLoginDataFieldAreEmpty()
        {
            Driver.Navigate().Refresh();
            var homePageModel = homeSrv.GetHomePageModel();
            homeSrv.ClickOnLoginButton(homePageModel);
            loginServices.GetLoginPageModel().LoginButton.Click();
            var validateField = Driver.FindElement(By.XPath(HtmlLoginPageElements.ValidateField));
            Assert.AreEqual(ValidateTextsHelper.FullValidateText, validateField.Text);
        }

        [Test]
        public void VerifyWrongLoginDataValidationText()
        {
            loginServices.SetLoginData("test","test","test");
            loginServices.GetLoginPageModel().LoginButton.Click();
            var validateField = Driver.FindElement(By.XPath(HtmlLoginPageElements.ValidateField));
            Assert.AreEqual(ValidateTextsHelper.ErrorValidateText, validateField.Text);
        }

    }
}
