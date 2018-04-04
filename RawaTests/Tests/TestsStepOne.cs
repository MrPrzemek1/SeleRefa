using RawaTests.StepOne;
using NUnit.Framework;
using RawaTests.Tests.Base;
using RawaTests.Services;
using RawaTests.Helpers;
using System.Threading;
using System.Linq;
using RawaTests.Model.StepTwo;

namespace RawaTests.Tests
{
    [TestFixture(Category ="StepOne")]
    class TestsStepOne : BaseTest
    {
        private DimensionServices dimensionSrv;
        private HomePageServices homePage;
        private Room3DServices roomServices;
        private ShapeRoomServices shapeServices;
        private StepOneServices stepOne;
        public TestsStepOne()
        {
            dimensionSrv = new DimensionServices();
            homePage = new HomePageServices();
            roomServices = new Room3DServices();
            shapeServices = new ShapeRoomServices();
            stepOne = new StepOneServices();
        }
        
        public override void End()
        {
            
        }

        public override void Init()
        {
            homePage.GetHomePageModel().StartButton.Click();
            roomServices.Get3DModel().Wait(3);
        }
        /// <summary>
        /// Test sprawdzajacy czy po kilknieciu w kształt pomieszczenia jego klasa zmienia sie na active
        /// </summary>
        [Test,Order(1)]
        public void VerifyClickedElementChangeClass()
        {
            //homePage.GetHomePageModel().StartButton.Click();
            stepOne.GetFullModel().Shapes.GetShapes().GetShapeById("30");
            var a = dimensionSrv.GetDimensions();
            a.GetFieldByDescription("E").PlusSign.Click();
            Assert.AreEqual("wallSizeInput changed", a.GetFieldByDescription("A").Input.GetAttribute("class"));            
        }

        [Test,Description("Test")]
        public void VerifyingModelRoomSizeAfterChangingDimension()
        {
            for (int i = 0; i < 100; i++)
            {
                stepOne.GetFullModel().Shapes.GetShapes().GetShapeById("28");
                ButtonHelper.ClickButtonNext();
                ButtonHelper.ClickButtonPrev();
                stepOne.GetFullModel().Shapes.GetShapes().GetShapeById("25");
                ButtonHelper.ClickButtonNext();
                ButtonHelper.ClickButtonPrev();
                stepOne.GetFullModel().Shapes.GetShapes().GetShapeById("23");
                ButtonHelper.ClickButtonNext();
                ButtonHelper.ClickButtonPrev();
                stepOne.GetFullModel().Shapes.GetShapes().GetShapeById("27");
                ButtonHelper.ClickButtonNext();
                ButtonHelper.ClickButtonPrev();
                stepOne.GetFullModel().Shapes.GetShapes().GetShapeById("26");
                ButtonHelper.ClickButtonNext();
                ButtonHelper.ClickButtonPrev();
                i++;
            }
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
