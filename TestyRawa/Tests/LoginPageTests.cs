using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestyRawa.DriverHelper;

namespace TestyRawa.Tests
{
    [TestFixture]
    [Category("Sprawdzanie strony logowania")]
    class LoginPageTests : LoginPage
    {
        IWebDriver driver { get { return DriverHelper.Browser.Driver; } }
       // LoginPage loginPage = new LoginPage();
        HomePage home = new HomePage();

        [OneTimeSetUp]
        public void TestInizialize()
        {
            Browser.Initialize();
            home.GoToLoginPage();
        }
        [OneTimeTearDown]
        public void EndTest()
        {
            Browser.Quit();
        }

        [Test, Description("Sprawdzenie pojawienia się okna logowania"), Order(1)]
        public void VerifyLoginFormPresent()
        {
            Assert.IsTrue(VerifyLoginFormIsDisplayed());
        }
        [Test,Description("Sprawdzenie poprawnosci logowania."),Order(2)]
        public void VerifyCorretlyUserLogin()
        {
            CorrectLogin();
            Assert.IsTrue(Browser.WaitUntilElementIsDisplayed(By.XPath("//button[contains(text(),'Wyloguj')]"), 5));
            driver.Navigate().Refresh();
        }
        [Test,Description("Sprawdzenie poprawności komunikatów walidacyjnych w przypadku złych danych do logowania"), Order(3)]
        public void VerifyValidateLoginForm()
        {
            home.GoToLoginPage();
            SetWrongDataToLogin("janusz", "test test", "asdrest");
            Assert.AreEqual("Nie udało się zalogować", GetValidateComunicat());
        }
    }
}
