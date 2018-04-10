using NUnit.Framework;
using RawaTests.Services;
using static RawaTests.Helpers.DriverHelper.DriverHelper;
using RawaTests.ValidateMessages;
using RawaTests.Managers;
using RawaTests.Tests.Base;
using RawaTests.Helpers;
using RawaTests.Model;

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

        [Test,Description("asdas"), Order(1)]
        public void CorrectLogin()
        {
            homeServices.GetHomePageModel().LoginBtn.Click();

            LoginPageModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetLoginData();
            loginPage.SubmitButton.Click();
            //loginPage.SubmitButton.Click();
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
