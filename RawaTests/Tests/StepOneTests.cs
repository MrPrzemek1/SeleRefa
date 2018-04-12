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
        private HomePageServices homePageServices;
        private DimensionServices dimensionServices;
        private ShapeRoomServices shapeServices;
        private Room3DServices roomViewServices;

        public StepOneTests()
        {
            homePageServices = new HomePageServices();
            dimensionServices = new DimensionServices();
            shapeServices = new ShapeRoomServices();
            roomViewServices = new Room3DServices();
        }

        [Test]
        public void VerifyClickedElementChangeClass()
        {
            Manager.Driver.Navigate().Refresh();
            homePageServices.GetHomePageModel().StartButton.Click();

            ShapeRoomPageModel shapes = shapeServices.GetShapes();
            Assert.IsTrue(shapes.ClickingOnTheShapes());
        }
        [Test]
        public void VerifyingModelRoomChangeAfterChangeShape()
        {
            Manager.Driver.Navigate().Refresh();
            homePageServices.GetHomePageModel().StartButton.Click();

            ShapeRoomPageModel shapes = shapeServices.GetShapes();
            shapes.ClickShapeById("27");
            Room3DViewPageModel roomView = roomViewServices.Get3DModel();
            var dimensionRoomView = roomView.GetRoomDimension();
            shapes.ClickShapeById("28");
            Room3DViewPageModel roomAfterChangeShape = roomViewServices.Get3DModel();
            var dimensionAfterChangeShape = roomAfterChangeShape.GetRoomDimension();
            Assert.AreNotSame(roomView.RoomImage, roomAfterChangeShape.RoomImage);
            Assert.AreNotEqual(dimensionRoomView, dimensionAfterChangeShape);
        }
        [Test]
        public void VerifingySizeOfRoomModelChangeAfterChangeDimension()
        {
            Manager.Driver.Navigate().Refresh();
            homePageServices.GetHomePageModel().StartButton.Click();

            Room3DViewPageModel roomModel = roomViewServices.Get3DModel();
            var roomDimension = roomModel.GetRoomDimension();
            DimensionsPageModel dimensionOfRoom = dimensionServices.GetDimensions();
            dimensionOfRoom.GetFieldByDescription("B").PlusSign.Click();
            Room3DViewPageModel roomModelAfterChange = roomViewServices.Get3DModel();
            var roomDimensionAfterChange = roomModelAfterChange.GetRoomDimension();

            Assert.AreNotEqual(roomDimension, roomDimensionAfterChange);
        }
        [Test]
        public void CheckingTheClassChangeForTheElementAfterChangingTheDimensionsOnTheDependentWall()
        {
            Manager.Driver.Navigate().Refresh();
            homePageServices.GetHomePageModel().StartButton.Click();

            ShapeRoomPageModel shapes = shapeServices.GetShapes();
            shapes.ClickShapeById("27");
            DimensionsPageModel roomDimension = dimensionServices.GetDimensions();
            roomDimension.GetFieldByDescription("A").PlusSign.Click();
            Assert.IsTrue(roomDimension.GetFieldByDescription("C").Input.GetAttribute("class").Equals("wallSizeInput changed"));
        }
    }
}
