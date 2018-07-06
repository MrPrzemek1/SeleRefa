using NUnit.Framework;
using RawaTests.Services;
using RawaTests.Managers;

namespace RawaTests.Tests
{
    [TestFixtureSource(typeof(DriverManager), "DriverType")]
    [TestFixture,Category("Home")]
    public class HomePageTests : BaseTest
    {
        HomePageWCServices homePageSrv;

        public HomePageTests() : base() { }

        public override void Init(DriverType type)
        {
            base.Init(type);
            homePageSrv = new HomePageWCServices(Manager);
        }

        [Test]
        public void HomePageElementsIsDisplayed([Values]DriverType type)
        {
            Init(type);
            Assert.IsTrue(homePageSrv.GetHomePageModel().IsValid());
        }
    }
}
