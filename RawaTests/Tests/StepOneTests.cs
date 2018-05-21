using RawaTests.StepOne;
using NUnit.Framework;
using RawaTests.Services;
using RawaTests.Lists;
using RawaTests.Tests;
using RawaTests.Managers;
using RawaTests.Services.Builder;

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

        public StepOneTests() : base()
        {

        }
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
            Init(type);
            homePageServices.GetHomePageModel().StartButton.ClickIfElementIsClickable(Manager.Driver);

            ShapesRoomWCModel shapes = shapeServices.GetShapes();
            Assert.IsTrue(shapes.ClickingOnTheShapes());
        }
        [Test, Order(2)]
        public void VerifyingModelRoomChangeAfterChangeShape([Values]DriverType type)
        {
            Init(type);
            homePageServices.GetHomePageModel().StartButton.ClickIfElementIsClickable(Manager.Driver);

            ShapesRoomWCModel shapes = shapeServices.GetShapes();
            shapes.ClickShapeById("27");
            Room3DWCModel roomView = roomViewServices.Get3DModel();
            var dimensionRoomView = roomView.Room3dImageDimension;
            shapes.ClickShapeById("28");
            Room3DWCModel roomAfterChangeShape = roomViewServices.Get3DModel();
            var dimensionAfterChangeShape = roomAfterChangeShape.Room3dImageDimension;
            Assert.AreNotSame(roomView.Room3dImageDimension, roomAfterChangeShape.Room3dImageDimension);
            Assert.AreNotEqual(dimensionRoomView, dimensionAfterChangeShape);
        }
        [Test, Order(3)]
        public void VerifingySizeOfRoomModelChangeAfterChangeDimension([Values]DriverType type)
        {
            Init(type);
            homePageServices.GetHomePageModel().StartButton.ClickIfElementIsClickable(Manager.Driver);

            Room3DWCModel roomModel = roomViewServices.Get3DModel();
            var roomDimension = roomModel.Room3dImageDimension;
            DimensionsWCModel dimensionOfRoom = dimensionServices.GetDimensions();
            dimensionOfRoom.GetFieldByDescription("B").PlusSign.ClickIfElementIsClickable(Manager.Driver);
            Room3DWCModel roomModelAfterChange = roomViewServices.Get3DModel();
            var roomDimensionAfterChange = roomModelAfterChange.Room3dImageDimension;

            Assert.AreNotEqual(roomDimension, roomDimensionAfterChange);
        }
        [Test, Order(4)]
        public void CheckingTheClassChangeForTheElementAfterChangingTheDimensionsOnTheDependentWall([Values]DriverType type)
        {
            Init(type);
            homePageServices.GetHomePageModel().StartButton.ClickIfElementIsClickable(Manager.Driver);

            ShapesRoomWCModel shapes = shapeServices.GetShapes();
            shapes.ClickShapeById("27");
            DimensionsWCModel roomDimension = dimensionServices.GetDimensions();
            roomDimension.GetFieldByDescription("A").PlusSign.ClickIfElementIsClickable(Manager.Driver);
            Assert.IsTrue(roomDimension.GetFieldByDescription("C").Input.GetAttribute("class").Equals("wallSizeInput changed"));
        }
    }
}
