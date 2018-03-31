using NUnit.Framework;
using RawaTests.Services;
using static RawaTests.Helpers.DriverHelper.DriverHelp;
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
            Initialize();        
        }

        [OneTimeTearDown]
        public void EndTest()
        {
            Quit();
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
