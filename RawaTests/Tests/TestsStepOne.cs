using RawaTests.StepOne;
using NUnit.Framework;
using RawaTests.Tests.Base;
using RawaTests.Services;
using RawaTests.Helpers;

namespace RawaTests.Tests
{
    [TestFixture(Category ="StepOne")]
    class TestsStepOne : BaseTest
    {
        private DimensionServices dimensionSrv;
        private ShapeRoomServices shapeRoomSrv;
        private Room3DServices room3dSrv;
        public TestsStepOne()
        {
            dimensionSrv = new DimensionServices();
            shapeRoomSrv = new ShapeRoomServices();
            room3dSrv = new Room3DServices();
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
            string expectedClass = "active";
            var usedShape = shapeRoomSrv.GetShapeByID("30");
            usedShape.ShapeOfRoom.Click();
            var usedShapeClass = shapeRoomSrv.GetUsedShapeAttribute(HTMLConsts.CLASS,usedShape);
            Assert.AreEqual(expectedClass, usedShapeClass);

        }

        [Test,Description("Test sprawdzający czy po kliknięciu w button do zwiększenia wymiarów pomieszczenia zmieniają się wymiary obrazka.")]
        public void VerifyingModelRoomSizeAfterChangingDimension()
        { 
            shapeRoomSrv.GetShapeByID("30").ShapeOfRoom.Click();           
            var firstModel = room3dSrv.Get3DModel();
            string firstModelStyle = firstModel.Style;
            dimensionSrv.GetDimensionModelByName("B").PlusSign.Click();
            var modelAfterClick = room3dSrv.Get3DModel();       
            Assert.IsFalse(modelAfterClick.Style.Equals(firstModelStyle));
        }
        [Test,Description("Test sprawdzający czy po kliknięciu w kształt pomieszczenia zmienia się model obrazka.")]
        public void VerifingyModelChangeAfterClickingOnShape_Positive()
        {
            var firstModel = room3dSrv.Get3DModel();
            shapeRoomSrv.GetShapeByID("30").ShapeOfRoom.Click();
            var modelAfterClick = room3dSrv.Get3DModel();
            Assert.AreNotEqual(firstModel,modelAfterClick);
        }
        [Test]
        public void VerifingyModelChangeAfterClickingOnShape_Negative()
        {
            var firstModel = room3dSrv.Get3DModel();            
            var modelAfterClick = room3dSrv.Get3DModel();
            shapeRoomSrv.GetShapeByID("30").ShapeOfRoom.Click();
            Assert.AreEqual(firstModel, modelAfterClick);
        }
        
    }
}
