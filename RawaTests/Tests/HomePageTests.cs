using NUnit.Framework;
using RawaTests.Services;
using RawaTests.Tests.Base;
using static TestyRawa.DriverHelper;

namespace RawaTests.Tests
{
    [TestFixture(Category ="HomePageTests")]
    class HomePageTests : IDriverService
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
            var homeModel = homePageSrv.GetHomePageModel();
            Assert.IsTrue(homeModel.StartButton.Displayed);
            Assert.IsTrue(homeModel.LogoImage.Displayed);
            Assert.IsTrue(homeModel.HomePageImage.Displayed);
        }
    }
}
