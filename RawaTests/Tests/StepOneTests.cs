using RawaTests.StepOne;
using NUnit.Framework;
using RawaTests.Services;
using RawaTests.Lists;
using RawaTests.Model.Room3D;
using RawaTests.Tests;
using RawaTests.Managers;

namespace RawaTests.Tests
{
    [TestFixture(Category = "Rawa")]
    class StepOneTests : BaseTest
    {
        private HomePageWCServices homePageServices;
        private DimensionWCServices dimensionServices;
        private ShapeRoomServices shapeServices;
        private Room3DServices roomViewServices;

        public StepOneTests()
        {
            homePageServices = new HomePageWCServices();
            dimensionServices = new DimensionWCServices();
            shapeServices = new ShapeRoomServices();
            roomViewServices = new Room3DServices();
        }

        [Test]
        public void VerifyClickedElementChangeClass()
        {
            Manager.Driver.Navigate().Refresh();
            homePageServices.GetHomePageModel().StartButton.Click();

            ShapesRoomWCModel shapes = shapeServices.GetShapes();
            Assert.IsTrue(shapes.ClickingOnTheShapes());
        }
        [Test]
        public void VerifyingModelRoomChangeAfterChangeShape()
        {
            Manager.Driver.Navigate().Refresh();
            homePageServices.GetHomePageModel().StartButton.Click();

            ShapesRoomWCModel shapes = shapeServices.GetShapes();
            shapes.ClickShapeById("27");
            Rooms3DWCModel roomView = roomViewServices.Get3DModel();
            var dimensionRoomView = roomView.GetRoomDimension();
            shapes.ClickShapeById("28");
            Rooms3DWCModel roomAfterChangeShape = roomViewServices.Get3DModel();
            var dimensionAfterChangeShape = roomAfterChangeShape.GetRoomDimension();
            Assert.AreNotSame(roomView.RoomImage, roomAfterChangeShape.RoomImage);
            Assert.AreNotEqual(dimensionRoomView, dimensionAfterChangeShape);
        }
        [Test]
        public void VerifingySizeOfRoomModelChangeAfterChangeDimension()
        {
            Manager.Driver.Navigate().Refresh();
            homePageServices.GetHomePageModel().StartButton.Click();

            Rooms3DWCModel roomModel = roomViewServices.Get3DModel();
            var roomDimension = roomModel.GetRoomDimension();
            DimensionsWCModel dimensionOfRoom = dimensionServices.GetDimensions();
            dimensionOfRoom.GetFieldByDescription("B").PlusSign.Click();
            Rooms3DWCModel roomModelAfterChange = roomViewServices.Get3DModel();
            var roomDimensionAfterChange = roomModelAfterChange.GetRoomDimension();

            Assert.AreNotEqual(roomDimension, roomDimensionAfterChange);
        }
        [Test]
        public void CheckingTheClassChangeForTheElementAfterChangingTheDimensionsOnTheDependentWall()
        {
            Manager.Driver.Navigate().Refresh();
            homePageServices.GetHomePageModel().StartButton.Click();

            ShapesRoomWCModel shapes = shapeServices.GetShapes();
            shapes.ClickShapeById("27");
            DimensionsWCModel roomDimension = dimensionServices.GetDimensions();
            roomDimension.GetFieldByDescription("A").PlusSign.Click();
            Assert.IsTrue(roomDimension.GetFieldByDescription("C").Input.GetAttribute("class").Equals("wallSizeInput changed"));
        }
        [Test]
        public void sdfsdf()
        {
            homePageServices.GetHomePageModel().StartButton.Click();
            
            DimensionsWCModel roomDimension = dimensionServices.GetDimensions();
            roomDimension.GetFieldByDescription("A");
            Assert.IsTrue(roomDimension.GetFieldByDescription("C").Input.GetAttribute("class").Equals("wallSizeInput changed"));
        }
    }
}
