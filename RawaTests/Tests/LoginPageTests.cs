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
        HomePageServices homeServices;

        public LoginPageTests()
        {
            loginServices = new LoginPageServices();
            homeServices = new HomePageServices();
        }

        [OneTimeSetUp]
        public void TestInizialize()
        {
            Browser.Initialize();        
        }

        [OneTimeTearDown]
        public void EndTest()
        {
            Browser.Quit();
        }

        [Test,Description("asdas"), Order(1)]
        public void CorrectLogin()
        {
            //var homePage = homeServices.GetHomePageModel();
            homeServices.GetHomePageModel().LoginBtn.Click();
            var loginPage = loginServices.GetLoginPageModel();
            loginPage.SetLoginData();
            loginPage.SubmitButton.Click();
            Assert.IsTrue(homeServices.GetHomePageModel().Logout.Contains(ValidateTextsHelper.LoginText));
        }

        [Test, Order(2)]
        public void VerifyingCompanyValidateTexts()
        {
          
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
