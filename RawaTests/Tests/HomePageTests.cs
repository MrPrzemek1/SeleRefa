using NUnit.Framework;
using RawaTests.Helpers;
using RawaTests.Managers;
using RawaTests.Services;
using RawaTests.Services.StepTwoServices;
using RawaTests.Services.StepTwoServices.PanelListForCabinets;
using System.Threading;

namespace RawaTests.Tests
{
    [TestFixture(Category ="Rawa")]
    class HomePageTests : BaseTest
    {
        HomePageWCServices homePageSrv;
        GroupOptionWCServices groupOptionServices;
        LeftTableStepTwoWCServices doorServices;
        public HomePageTests()
        {
            homePageSrv = new HomePageWCServices();
            groupOptionServices = new GroupOptionWCServices();
            doorServices = new LeftTableStepTwoWCServices();
        }
        [Test]
        public void HomePageElementsIsDisplayed()
        {
            Assert.IsTrue(homePageSrv.GetHomePageModel().IsValid());
        }
    }
}
