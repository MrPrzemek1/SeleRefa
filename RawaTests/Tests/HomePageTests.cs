using NUnit.Framework;
using RawaTests.Services;
using RawaTests.Services.StepTwoServices;
using RawaTests.Services.StepTwoServices.PanelListForCabinets;

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
            homePageSrv = new HomePageWCServices(Manager);
            groupOptionServices = new GroupOptionWCServices(Manager);
            doorServices = new LeftTableStepTwoWCServices(Manager);
        }
        [Test]
        public void HomePageElementsIsDisplayed()
        {
            Assert.IsTrue(homePageSrv.GetHomePageModel().IsValid());
        }
    }
}
