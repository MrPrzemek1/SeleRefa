using NUnit.Framework;
using RawaTests.Helpers;
using RawaTests.Lists;
using RawaTests.Model;
using RawaTests.Services;
using RawaTests.Services.StepTwoServices;
using RawaTests.StepOne;
using RawaTests.ValidateMessages;
using RawaTests.Services.StepTwoServices.PanelListForCabinets;
using RawaTests.Model.Login;
using System.IO;
using RawaTests.Managers;
using System.Drawing;
using OpenQA.Selenium.Interactions;
using System.Threading;
using RawaTests.HtmlStrings.ConstStrings;
using XnaFan.ImageComparison;
using System;
using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo;
using RawaTests.Extensions;
namespace RawaTests.Tests
{
    [TestFixture]
    class AllTests : BaseTest
    {
        HomePageWCServices homeServices;
        LoginPageWCServices loginServices;
        private DimensionWCServices dimensionServices;
        private ShapeRoomWCServices shapeServices;
        private Room3DWCServices roomViewServices;
        GroupOptionWCServices groupOptionServices;
        LeftTableStepTwoWCServices leftPanelServices;
        CanvasWCServices canvasServices;
        ActiveCabinetWCServices activeCabinetServices;
        ColorPickerServies colorPickerServices;
        public AllTests()
        {
            homeServices = new HomePageWCServices();
            loginServices = new LoginPageWCServices();
            dimensionServices = new DimensionWCServices();
            shapeServices = new ShapeRoomWCServices();
            roomViewServices = new Room3DWCServices();
            groupOptionServices = new GroupOptionWCServices();
            leftPanelServices = new LeftTableStepTwoWCServices();
            canvasServices = new CanvasWCServices();
            activeCabinetServices = new ActiveCabinetWCServices();
            colorPickerServices = new ColorPickerServies();
        }
        [Test,Order(1)]
        public void HomePageElementsIsDisplayed()
        {
            Assert.IsTrue(homeServices.GetHomePageModel().IsValid());

        }
        [Test, Order(2)]
        public void CorrectLogin()
        {
            homeServices.GetHomePageModel().LoginBtn.ClickIfElementIsClickable();

            LoginPageWCModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetCorrectLoginData();
            loginPage.SubmitButton.ClickIfElementIsClickable();
            HomePageWCModel homePageAfterLogin = homeServices.GetHomePageModel();
            Assert.IsTrue(homePageAfterLogin.LogoutDiv.Displayed);
            Assert.IsTrue(homePageAfterLogin.LogoutDiv.Text.Equals(ValidateTextsHelper.CorrectLoginText));
        }

        [Test, Order(3)]
        public void VerifyingValidateTextWhenCompanyNameIsEmpty()
        {
            homeServices.GetHomePageModel().LogoutButton.ClickIfElementIsClickable();
            homeServices.GetHomePageModel().LoginBtn.ClickIfElementIsClickable();

            LoginPageWCModel loginPage = loginServices.GetLoginPageModel();
            loginPage.LoginInput.SendKeys("Test");
            loginPage.PasswordInput.SendKeys("test");
            loginPage.SubmitButton.ClickIfElementIsClickable();
            LoginPageWCModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateFieldIsDisplayed);
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.CompanyValidateText));
        }
        [Test, Order(4)]
        public void VerifingValidateTextWhenUserNameIsEmpty()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.ClickIfElementIsClickable();
            LoginPageWCModel loginPage = loginServices.GetLoginPageModel();
            loginPage.CompanyNameInput.SendKeys("lalala");
            loginPage.PasswordInput.SendKeys("lalala");
            loginPage.SubmitButton.ClickIfElementIsClickable();
            LoginPageWCModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.LoginValidateText));
        }
        [Test, Order(5)]
        public void VerifingValidateTextPasswordFieldIsEmpty()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.ClickIfElementIsClickable();
            LoginPageWCModel loginPage = loginServices.GetLoginPageModel();
            loginPage.CompanyNameInput.SendKeys("lalala");
            loginPage.LoginInput.SendKeys("lalala");
            loginPage.SubmitButton.Click();
            LoginPageWCModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.PasswordValidateText));
        }
        [Test, Order(6)]
        public void VerifingValidateTextWhenLoginDataWasIncorrect()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.ClickIfElementIsClickable();
            LoginPageWCModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetLoginData("Test", "Test", "Test");
            loginPage.SubmitButton.ClickIfElementIsClickable();
            LoginPageWCModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.ErrorValidateText));
        }
        [Test, Order(7)]
        public void VerifyClickedElementChangeClass()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().StartButton.ClickIfElementIsClickable();

            ShapesRoomWCModel shapes = shapeServices.GetShapes();
            Assert.IsTrue(shapes.ClickingOnTheShapes());
        }
        [Test, Order(8)]
        public void VerifyingModelRoomChangeAfterChangeShape()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().StartButton.ClickIfElementIsClickable();

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
        [Test, Order(9)]
        public void VerifingySizeOfRoomModelChangeAfterChangeDimension()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().StartButton.ClickIfElementIsClickable();

            Room3DWCModel roomModel = roomViewServices.Get3DModel();
            var roomDimension = roomModel.GetRoomDimension();
            DimensionsWCModel dimensionOfRoom = dimensionServices.GetDimensions();
            dimensionOfRoom.GetFieldByDescription("B").PlusSign.ClickIfElementIsClickable();
            Room3DWCModel roomModelAfterChange = roomViewServices.Get3DModel();
            var roomDimensionAfterChange = roomModelAfterChange.GetRoomDimension();

            Assert.AreNotEqual(roomDimension, roomDimensionAfterChange);
        }
        [Test, Order(10)]
        public void ChangesFloorColorUsingColorPallete()
        {
            ButtonHelper.ClickButtonNext();
            string pathfirst = ImageHelper.MakeScreenshot();
            var canvas = canvasServices.GetCanvasModel();
            canvas.OpenColorPickerOnCanvas();
            ColorPickerWCModel colorpicker = colorPickerServices.GetFullColorPickerModel();
            colorpicker.allColors.GetRandomColor().ClickIfElementIsClickable();
            colorpicker.rightPanel.SubmitButton.ClickIfElementIsClickable();
            string pathsecond = ImageHelper.MakeScreenshot();
            Assert.IsTrue(ImageHelper.CheckingImagesAreDifferent(pathfirst, pathsecond));
            File.Delete(pathfirst);
            File.Delete(pathsecond);
        }
        [Test, Order(11)]
        public void ChangeColorUsingColorSlider()
        {
            string pathfirst = ImageHelper.MakeScreenshot();
            var canvas = canvasServices.GetCanvasModel();
            canvas.OpenColorPickerOnCanvas();
            ColorPickerWCModel colorpicker = colorPickerServices.GetFullColorPickerModel();
            colorpicker.rightPanel.ColorSlider.ChangeColorWithSlider(-20);
            colorpicker.rightPanel.SubmitButton.Click();
            string pathsecond = ImageHelper.MakeScreenshot();
            Assert.IsTrue(ImageHelper.CheckingImagesAreDifferent(pathfirst, pathsecond));
            File.Delete(pathfirst);
            File.Delete(pathsecond);
        }
        [Test, Order(12)]
        public void ChangeColorUsingColorSquare()
        {
            string pathfirst = ImageHelper.MakeScreenshot();
            var canvas = canvasServices.GetCanvasModel();
            canvas.OpenColorPickerOnCanvas();
            ColorPickerWCModel colorpicker = colorPickerServices.GetFullColorPickerModel();
            colorpicker.rightPanel.ChangeColorWithSquare();
            colorpicker.rightPanel.SubmitButton.Click();
            string pathsecond = ImageHelper.MakeScreenshot();
            Assert.IsTrue(ImageHelper.CheckingImagesAreDifferent(pathfirst, pathsecond));
            File.Delete(pathfirst);
            File.Delete(pathsecond);
        }
        [Test]
        public void TestDragDropa()
        {
            homeServices.GetHomePageModel().StartButton.ClickIfElementIsClickable();
            ButtonHelper.ClickButtonNext();
            groupOptionServices.GetOptionModel().GetOptionDoor();
            var door = leftPanelServices.GetPanelForDoors().GetRandomDoor();
            var canvas = canvasServices.GetCanvasModel().CanvasImage;
            Actions actions1 = new Actions(DriverManager.CreateInstance().Driver);
            actions1.ClickAndHold(canvas)
                .MoveByOffset(100, -50)
                .Release()
                .Build()
                .Perform();
            for (int i = 0; i < 1200; i++)
            {
                Actions actions = new Actions(DriverManager.CreateInstance().Driver);
                actions
                    .DragAndDrop(door,canvas)
                    .Release()
                    .Build()
                    .Perform();
                i++;
            }                          
        }

    }
}
