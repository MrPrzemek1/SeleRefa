using NUnit.Framework;
using RawaTests.Helpers;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Services;
using static RawaTests.Helpers.DriverHelper.DriverHelper;

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
           
        }
        [OneTimeTearDown]
        public void EndTest()
        {
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
