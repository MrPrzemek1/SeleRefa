using NUnit.Framework;
using RawaTests.Services;
using RawaTests.ValidateMessages;
using RawaTests.Model;
using RawaTests.Model.Login;
using RawaTests.Managers;

namespace RawaTests.Tests
{
    [TestFixture,Category("Login")]
    [TestFixtureSource(typeof(DriverManager), "DriverType")]
    public class LoginPageTests : BaseTest
    {
        LoginPageWCServices loginServices;
        HomePageWCServices homeServices;

        public LoginPageTests() : base() { }

        public override void Init(DriverType type)
        {
            base.Init(type);
            homeServices = new HomePageWCServices(Manager);
            loginServices = new LoginPageWCServices(Manager);
        }
        [Test, Order(1)]
        public void CorrectLogin([Values]DriverType type)
        {
            InitializeAndGotoLoginPage(type);
            LoginPageWCModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetCorrectLoginData();
            loginPage.SubmitButton.Click();
            HomePageWCModel homePageAfterLogin = homeServices.GetHomePageModel();
            Assert.IsTrue(homePageAfterLogin.LogoutDiv.Displayed);
            Assert.IsTrue(homePageAfterLogin.LogoutDiv.Text.Equals(ValidateTextsHelper.CorrectLoginText));
        }

        [Test, Order(2)]
        public void VerifyingValidateTextWhenCompanyNameIsEmpty([Values]DriverType type)
        {
            InitializeAndGotoLoginPage(type);
            LoginPageWCModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetLoginData(string.Empty,"test", "test");
            LoginPageWCModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateFieldIsDisplayed);
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.CompanyValidateText));
        }
        [Test, Order(3)]
        public void VerifingValidateTextWhenUserNameIsEmpty([Values]DriverType type)
        {
            InitializeAndGotoLoginPage(type);
            LoginPageWCModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetLoginData("test", string.Empty, "test");
            LoginPageWCModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.LoginValidateText));
        }
        [Test, Order(4)]
        public void VerifingValidateTextPasswordFieldIsEmpty([Values]DriverType type)
        {
            InitializeAndGotoLoginPage(type);
            LoginPageWCModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetLoginData("test","test");
            LoginPageWCModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.PasswordValidateText));
        }
        [Test, Order(5)]
        public void VerifingValidateTextWhenLoginDataWasIncorrect([Values]DriverType type)
        {
            InitializeAndGotoLoginPage(type);
            LoginPageWCModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetLoginData("Test", "Test", "Test");
            loginPage.SubmitLoginForm();
            LoginPageWCModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.ErrorValidateText));
        }

        private void InitializeAndGotoLoginPage(DriverType type)
        {
            Init(type);
            homeServices.GetHomePageModel().GotoLoginPage();
        }
    }
}
