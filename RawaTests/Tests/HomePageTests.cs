using NUnit.Framework;
using RawaTests.Helpers;
using RawaTests.Services;
using RawaTests.Tests.Base;
using static TestyRawa.DriverHelper;

namespace RawaTests.Tests
{
    [TestFixture(Category ="HomePageTests")]
    class HomePageTests
    {
        HomePageServices homePageSrv;
        public HomePageTests()
        {
            homePageSrv = new HomePageServices();
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
        [Test]
        public void HomePageElementsIsDisplayed()
        {
            var homePage = homePageSrv.GetHomePageModel();
            Assert.IsTrue(homePage.IsValid());
        }
        [Test]
        public void HomePage()
        {
            var homePage = homePageSrv.GetHomePageModel();
            Assert.AreEqual(HtmlHomePageElements.HomePageUrl, homePage.HomePageImage.GetImageSource());
        }
    }
}
