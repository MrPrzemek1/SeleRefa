using NUnit.Framework;
using RawaTests.Services;
using RawaTests.Services.StepTwoServices;
using RawaTests.Services.StepTwoServices.PanelListForCabinets;
using RawaTests.Managers;
using System.Collections.Generic;
using RawaTests.Services.Builder;

namespace RawaTests.Tests
{
    [TestFixtureSource(typeof(DriverManager), "DriverType")]
    [TestFixture,Category("Home")]
    class HomePageTests : BaseTest
    {
        HomePageWCServices homePageSrv;

        public HomePageTests() : base()
        {
           
        }

        public override void Init(DriverType type)
        {
            base.Init(type);
            homePageSrv = ServiceBuilder.BuildService<HomePageWCServices>(Manager);
        }

        [Test]
        public void HomePageElementsIsDisplayed([Values]DriverType type)
        {
            Init(type);
            Assert.IsTrue(homePageSrv.GetHomePageModel().IsValid());
        }
    }
}
