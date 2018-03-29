using NUnit.Framework;
using OpenQA.Selenium;
using System;
using static TestyRawa.DriverHelper;
using SeleniumExtras.WaitHelpers;
namespace TestyRawa
{
    [TestFixture]
    [Category("Weryfikacja strony głównej")]
    class HomePageTests : HomePage
    {
        //private IWebDriver driver = Browser.GetDriver(Drivers.Chrome);
       // HomePage homePage = new HomePage();

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
        [Test, Description("Sprawdzenie tytułu załadowaniej strony")]
        public void VerifyTitleWebSite()
        {
            Assert.AreEqual("3D Konfigurator",Browser.Title);
            Console.WriteLine("Passed");
        }

        [Test, Description("Pojawienie sie przycisku start")]
        public void VerifyStartButtonIsDisplayed()
        {
            var StartButtonText = GetStartButtonText();            
            Assert.IsTrue(Browser.ElementIsDisplayed(By.TagName("button")));
            Assert.AreEqual("START", StartButtonText);
        }
        [Test, Description("Pojawienie się obrazków")]
        public void VerifyImagesPresent()
        {
            Assert.IsTrue(HomePageImgIsPresentOnPage());
            Assert.IsTrue(HomePageLogoImgIsPresentOnPage());
        }
        [Test,Description("Sprawdzenie poprawności tekstu w stopce i pojawienia się jej")]
        public void VerifyFooterTextIsCorrect()
        {
            Assert.AreEqual(GetFooterText(), "© 2018 RAWA Fabryka Mebli. Wszelkie prawa zastrzeżone.");
        }
    }
}

