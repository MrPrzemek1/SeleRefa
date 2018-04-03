using RawaTests.StepOne;
using NUnit.Framework;
using RawaTests.Tests.Base;
using RawaTests.Services;
using RawaTests.Helpers;
using System.Threading;
using System.Linq;

namespace RawaTests.Tests
{
    [TestFixture(Category ="StepOne")]
    class TestsStepOne : BaseTest
    {
        private DimensionServices dimensionSrv;
        private HomePageServices homePage;
        private Room3DServices roomServices;
        public TestsStepOne()
        {
            dimensionSrv = new DimensionServices();
            homePage = new HomePageServices();
            roomServices = new Room3DServices();
        }
        
        public override void End()
        {
            
        }

        public override void Init()
        {
            
        }
        /// <summary>
        /// Test sprawdzajacy czy po kilknieciu w kształt pomieszczenia jego klasa zmienia sie na active
        /// </summary>
        [Test,Order(1)]
        public void VerifyClickedElementChangeClass()
        {
            Thread.Sleep(2000);
            homePage.GetHomePageModel().StartButton.Click();
            Thread.Sleep(1000);
            
            var room = roomServices.Get3DModel();
            var dupa = room.GetRoomDimension();
            dimensionSrv.GetDimensions().GetFieldByDescription("A").PlusSign.Click();
            var room2= roomServices.Get3DModel();
            var dup2 = room2.GetRoomDimension();
            Assert.AreEqual(dupa, dup2);
        }

        [Test,Description("Test")]
        public void VerifyingModelRoomSizeAfterChangingDimension()
        { 
           
        }
        [Test,Description("Test 2")]
        public void VerifingyModelChangeAfterClickingOnShape_Positive()
        {
            
        }
        [Test]
        public void VerifingyModelChangeAfterClickingOnShape_Negative()
        {
        }
        
    }
}
