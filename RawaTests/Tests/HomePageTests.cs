using NUnit.Framework;
using RawaTests.Services;
using RawaTests.Services.StepTwoServices;
using RawaTests.Services.StepTwoServices.PanelListForCabinets;
using RawaTests.Managers;
using System.Collections.Generic;

namespace RawaTests.Tests
{
    [TestFixture,Category("Home")]
    class HomePageTests : BaseTest
    {
        HomePageWCServices homePageSrv;
        GroupOptionWCServices groupOptionServices;
        LeftTableStepTwoWCServices doorServices;
        public HomePageTests() : base()
        {

        }
        [Test]
        [TestCaseSource(typeof(DriverManager),"DriverType")]
        public void HomePageElementsIsDisplayed([Values]DriverManager.DriverType type)
        {
            TestInizialize(type);

            homePageSrv = new HomePageWCServices(Manager);
            groupOptionServices = new GroupOptionWCServices(Manager);
            doorServices = new LeftTableStepTwoWCServices(Manager);

            Assert.IsTrue(homePageSrv.GetHomePageModel().IsValid());
        }
    }
}
