using NUnit.Framework;
using RawaTests.Helpers;
using RawaTests.Managers;
using RawaTests.Services;
using RawaTests.Services.StepTwoServices;
using System.Threading;

namespace RawaTests.Tests
{
    [TestFixture(Category ="Rawa")]
    class HomePageTests : BaseTest
    {
        HomePageServices homePageSrv;
        GroupOptionServices groupOptionServices;
        PanelListDoorServices doorServices;
        public HomePageTests()
        {
            homePageSrv = new HomePageServices();
            groupOptionServices = new GroupOptionServices();
            doorServices = new PanelListDoorServices();
        }
        [Test]
        public void HomePageElementsIsDisplayed()
        {
            Assert.IsTrue(homePageSrv.GetHomePageModel().IsValid());
        }
        [Test]
        public void Test()
        {
            homePageSrv.GetHomePageModel().StartButton.Click();
            ButtonHelper.ClickButtonNext();
            Thread.Sleep(2000);
            var a = groupOptionServices.GetOptionModel();
            a.GetOptionDoor();
            var b = doorServices.GetPanelForDoors();
            var c = b.GetDoorId();
            
        }
    }
}
