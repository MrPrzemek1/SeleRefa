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
        }

        [OneTimeTearDown]
        public void EndTest()
        {
            Browser.Quit();
        }

        [Test,Description("asdas"), Order(1)]
        public void CorrectLogin()
        {
          
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
