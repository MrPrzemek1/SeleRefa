using NUnit.Framework;
using RawaTests.Lists;
using RawaTests.Model;
using RawaTests.Model.Home;
using RawaTests.Model.Room3D;
using RawaTests.Services;
using RawaTests.StepOne;
using RawaTests.ValidateMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Tests
{
    [TestFixture]
    class AllTests : BaseTest
    {
        HomePageServices homeServices;
        LoginPageServices loginServices;
        private DimensionServices dimensionServices;
        private ShapeRoomServices shapeServices;
        private Room3DServices roomViewServices;

        public AllTests()
        {
            homeServices = new HomePageServices();
            loginServices = new LoginPageServices();
            dimensionServices = new DimensionServices();
            shapeServices = new ShapeRoomServices();
            roomViewServices = new Room3DServices();
        }
        [Test,Order(1)]
        public void HomePageElementsIsDisplayed()
        {
            Assert.IsTrue(homeServices.GetHomePageModel().IsValid());

        }
        [Test, Order(2)]
        public void CorrectLogin()
        {
            homeServices.GetHomePageModel().LoginBtn.Click();

            LoginPageModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetCorrectLoginData();
            loginPage.SubmitButton.Click();
            HomePageModel homePageAfterLogin = homeServices.GetHomePageModel();
            Assert.IsTrue(homePageAfterLogin.LogoutDiv.Dispalyed());
            Assert.IsTrue(homePageAfterLogin.LogoutDiv.Text.Equals(ValidateTextsHelper.CorrectLoginText));
        }

        [Test, Order(3)]
        public void VerifyingValidateTextWhenCompanyNameIsEmpty()
        {
            homeServices.GetHomePageModel().LogoutButton.Click();
            Manager.Driver.SwitchTo().Alert().Accept();
            homeServices.GetHomePageModel().LoginBtn.Click();

            LoginPageModel loginPage = loginServices.GetLoginPageModel();
            loginPage.LoginInput.SendText("Test");
            loginPage.PasswordInput.SendText("test");
            loginPage.SubmitButton.Click();
            LoginPageModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateFieldIsDisplayed);
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.CompanyValidateText));
        }
        [Test, Order(4)]
        public void VerifingValidateTextWhenUserNameIsEmpty()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.Click();
            LoginPageModel loginPage = loginServices.GetLoginPageModel();
            loginPage.CompanyNameInput.SendText("lalala");
            loginPage.PasswordInput.SendText("lalala");
            loginPage.SubmitButton.Click();
            LoginPageModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.LoginValidateText));
        }
        [Test, Order(5)]
        public void VerifingValidateTextPasswordFieldIsEmpty()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.Click();
            LoginPageModel loginPage = loginServices.GetLoginPageModel();
            loginPage.CompanyNameInput.SendText("lalala");
            loginPage.LoginInput.SendText("lalala");
            loginPage.SubmitButton.Click();
            LoginPageModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.PasswordValidateText));
        }
        [Test, Order(6)]
        public void VerifingValidateTextWhenLoginDataWasIncorrect()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.Click();
            LoginPageModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetLoginData("Test", "Test", "Test");
            loginPage.SubmitButton.Click();
            LoginPageModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.ErrorValidateText));
        }
        [Test, Order(7)]
        public void VerifyClickedElementChangeClass()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().StartButton.Click();

            ShapeRoomPageModel shapes = shapeServices.GetShapes();
            Assert.IsTrue(shapes.ClickingOnTheShapes());
        }
        [Test, Order(8)]
        public void VerifyingModelRoomChangeAfterChangeShape()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().StartButton.Click();

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
        [Test, Order(9)]
        public void VerifingySizeOfRoomModelChangeAfterChangeDimension()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().StartButton.Click();

            Room3DViewPageModel roomModel = roomViewServices.Get3DModel();
            var roomDimension = roomModel.GetRoomDimension();
            DimensionsPageModel dimensionOfRoom = dimensionServices.GetDimensions();
            dimensionOfRoom.GetFieldByDescription("B").PlusSign.Click();
            Room3DViewPageModel roomModelAfterChange = roomViewServices.Get3DModel();
            var roomDimensionAfterChange = roomModelAfterChange.GetRoomDimension();

            Assert.AreNotEqual(roomDimension, roomDimensionAfterChange);
        }
        [Test, Order(10)]
        public void CheckingTheClassChangeForTheElementAfterChangingTheDimensionsOnTheDependentWall()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().StartButton.Click();

            ShapeRoomPageModel shapes = shapeServices.GetShapes();
            shapes.ClickShapeById("27");
            DimensionsPageModel roomDimension = dimensionServices.GetDimensions();
            roomDimension.GetFieldByDescription("A").PlusSign.Click();
            Assert.IsTrue(roomDimension.GetFieldByDescription("C").Input.GetAttribute("class").Equals("wallSizeInput changed"));
        }

    }
}
