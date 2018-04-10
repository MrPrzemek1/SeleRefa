using RawaTests.StepOne;
using NUnit.Framework;
using RawaTests.Tests.Base;
using RawaTests.Services;
using System.Threading;
using RawaTests.Model.StepTwo;
using RawaTests.Services.StepTwoServices;
using RawaTests.Lists;

namespace RawaTests.Tests
{
    [TestFixture(Category ="StepOne")]
    class TestsStepOne : BaseTest
    {
        private HomePageServices homePage;
        private StepOneFacade StepOneFcd;
        private GroupOptionServices optionServices;
        private DimensionServices dimSrv;

        public TestsStepOne()
        {
            homePage = new HomePageServices();
            StepOneFcd = FacadeBuilder.GetStepOneFacade();
            dimSrv = new DimensionServices();

            optionServices = new GroupOptionServices();
        }
        /// <summary>
        /// Test sprawdzajacy czy po kilknieciu w kształt pomieszczenia jego klasa zmienia sie na active
        /// </summary>
        [Test,Order(1)]
        public void VerifyClickedElementChangeClass()
        {
            ShapeRoomPageModel shapes = StepOneFcd.GetShapes();
            shapes.ClickShapeById("28");
            DimensionsPageModel dim = StepOneFcd.GetDimensions();
            dim.GetFieldByDescription("A").PlusSign.Click();
            DimensionsPageModel dim2 = StepOneFcd.GetDimensions();
            dim2.GetFieldByDescription("E").PlusSign.Click();
            Assert.AreEqual("wallSizeInput changed", dim2.GetFieldByDescription("A").Input.GetAttribute("class"));
        }

        [Test,Description("Test")]
        public void VerifyingModelRoomSizeAfterChangingDimension()
        {

            var a = StepOneFcd.GetRoomDimension();

        }
        [Test,Description("Test 2")]
        public void VerifingyModelChangeAfterClickingOnShape_Positive()
        {
            Thread.Sleep(2000);
            var a = dimSrv.GetDimensions();
            var b = a.GetFieldByDescription("B");
            b.PlusSign.Click();
            
        }
        [Test]
        public void VerifingyModelChangeAfterClickingOnShape_Negative()
        {
        }
        
    }
}
