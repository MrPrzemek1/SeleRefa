using RawaTests.StepOne;
using NUnit.Framework;
using RawaTests.Services;
using RawaTests.Lists;
using RawaTests.Managers;

namespace RawaTests.Tests
{
    [TestFixtureSource(typeof(DriverManager), "DriverType")]
    [TestFixture, Category("StepOne")]
    class StepOneTests : BaseTest
    {
        private HomePageWCServices homePageServices;
        private DimensionWCServices dimensionServices;
        private ShapeRoomWCServices shapeServices;
        private Room3DWCServices roomViewServices;

        public StepOneTests() : base() { }

        public override void Init(DriverType type)
        {
            base.Init(type);
            homePageServices = new HomePageWCServices(Manager);
            dimensionServices = new DimensionWCServices(Manager);
            shapeServices = new ShapeRoomWCServices(Manager);
            roomViewServices = new Room3DWCServices(Manager);
        }
        [Test, Order(1)]
        public void VerifyClickedElementChangeClass([Values]DriverType type)
        {
            InizializeAndGoToStepOne(type);

            ShapesRoomWCModel shapes = shapeServices.GetShapes();
            Assert.IsTrue(shapes.ClickingOnTheShapes());
        }
        [Test, Order(2)]
        public void VerifyingModelRoomChangeAfterChangeShape([Values]DriverType type)
        {
            InizializeAndGoToStepOne(type);

            ShapesRoomWCModel shapes = shapeServices.GetShapes();
            shapes.ClickShapeById("27");
            Room3DWCModel roomView = roomViewServices.Get3DModel();
            var dimensionRoomView = roomView.room3dImageDimension;
            shapes.ClickShapeById("28");
            Room3DWCModel roomAfterChangeShape = roomViewServices.Get3DModel();
            var dimensionAfterChangeShape = roomAfterChangeShape.room3dImageDimension;
            Assert.AreNotSame(roomView.room3dImageDimension, roomAfterChangeShape.room3dImageDimension);
            Assert.AreNotEqual(dimensionRoomView, dimensionAfterChangeShape);
        }
        [Test, Order(3)]
        public void VerifingySizeOfRoomModelChangeAfterChangeDimension([Values]DriverType type)
        {
            InizializeAndGoToStepOne(type);

            Room3DWCModel roomModel = roomViewServices.Get3DModel();
            var roomDimension = roomModel.room3dImageDimension;
            DimensionsWCModel dimensionOfRoom = dimensionServices.GetDimensions();
            dimensionOfRoom.GetFieldByDescription("B").plusSign.ClickIfElementIsClickable(Manager.Driver);
            Room3DWCModel roomModelAfterChange = roomViewServices.Get3DModel();
            var roomDimensionAfterChange = roomModelAfterChange.room3dImageDimension;
            Assert.AreNotEqual(roomDimension, roomDimensionAfterChange);
        }
        [Test, Order(4)]
        public void CheckingTheClassChangeForTheElementAfterChangingTheDimensionsOnTheDependentWall([Values]DriverType type)
        {
            InizializeAndGoToStepOne(type);

            ShapesRoomWCModel shapes = shapeServices.GetShapes();
            shapes.ClickShapeById("27");
            DimensionsWCModel roomDimension = dimensionServices.GetDimensions();
            roomDimension.GetFieldByDescription("A").plusSign.ClickIfElementIsClickable(Manager.Driver);
            Assert.IsTrue(roomDimension.GetFieldByDescription("C").input.GetAttribute("class").Equals("wallSizeInput changed"));
        }

        private void InizializeAndGoToStepOne(DriverType type)
        {
            Init(type);
            homePageServices.GetHomePageModel().startButton.ClickIfElementIsClickable(Manager.Driver);
        }
    }
}
