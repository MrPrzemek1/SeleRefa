using NUnit.Framework;
using RawaTests.Helpers;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Services;
using static RawaTests.Helpers.DriverHelper.DriverHelp;

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
            Initialize();
        }
        [OneTimeTearDown]
        public void EndTest()
        {
            Quit();
        }
        [Test]
        public void HomePageElementsIsDisplayed()
        {
           
        }
        [Test]
        public void HomePage()
        {

        }
    }
}
