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
        GroupOptionWCServices groupOptionServices;
        LeftTableStepTwoWCServices doorServices;

        public HomePageTests() : base()
        {
           
        }

        private void Init(DriverType type)
        {
            InizializeManager(type);
            homePageSrv = ServiceBuilder.BuildService<HomePageWCServices>(Manager);
            groupOptionServices = ServiceBuilder.BuildService<GroupOptionWCServices>(Manager);
            doorServices = ServiceBuilder.BuildService<LeftTableStepTwoWCServices>(Manager);
        }

        [Test]
        public void HomePageElementsIsDisplayed([Values]DriverType type)
        {
            Init(type);
            Assert.IsTrue(homePageSrv.GetHomePageModel().IsValid());
        }
    }
}
