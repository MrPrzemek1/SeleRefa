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
using System;
using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo;
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
        ActiveDoorWCServices activeDoorServices;
        ActiveWindowWCServices activeWindowServices;
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
            activeDoorServices = new ActiveDoorWCServices();
            activeWindowServices = new ActiveWindowWCServices();
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
        }
        [Test]
        public void DragAndDropDoors()
        {
            groupOptionServices.GetOptionModel().GetOptionDoor();
            IWebElement door = leftPanelServices.GetPanelForDoors().GetRandomDoor();
            IWebElement canvas = canvasServices.GetCanvasModel().CanvasImage;
            ActionsManager.CreateAction().RotateElement(canvas);
            ActionsManager.CreateAction().CustomDragAndDropForWindowAndDoor(door,canvas);

            Assert.IsTrue(activeDoorServices.GetActiveDoorForm().IsValid());
        }
        [Test]
        public void DeleteActiveDoor()
        {
            groupOptionServices.GetOptionModel().GetOptionDoor();
            IWebElement door = leftPanelServices.GetPanelForDoors().GetRandomDoor();
            IWebElement canvas = canvasServices.GetCanvasModel().CanvasImage;
            ActionsManager.CreateAction().RotateElement(canvas);
            ActionsManager.CreateAction().CustomDragAndDropForWindowAndDoor(door, canvas);
            activeDoorServices.GetActiveDoorForm().DeleteButton.ClickIfElementIsClickable();
            DriverManager.CreateInstance().AcceptAlert();
            try
            {
                Assert.IsTrue(!activeDoorServices.GetActiveDoorForm().IsValid());
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "Test zaliczony");
            }
        }
        [Test]
        public void VerifyRotateCabinetUsingInput()
        {
            homeServices.GetHomePageModel().StartButton.ClickIfElementIsClickable();
            ButtonHelper.ClickButtonNext();
            groupOptionServices.GetOptionModel().GetOptionCabinetsSimply();
            IWebElement cabinets = leftPanelServices.GetSimplyLowerCabintesModel().ImagesOfCabinets;
            IWebElement canvas = canvasServices.GetCanvasModel().CanvasImage;
            ActionsManager.CreateAction().RotateElement(canvas, -100, 50);
            ActionsManager.CreateAction().CustomDragAndDropForCabinets(cabinets, canvas,30,30);
            string screenOne = ImageHelper.MakeScreenshot();
            var model = activeCabinetServices.GetActiveCabinetModel();
            model.RightPanel.RotationInput.SendKeys("2");
            ActionsManager.CreateAction().Click(model.LeftPanel.CabinetImageThumb).Build().Perform();
            string screenSecond = ImageHelper.MakeScreenshot();

            Assert.IsTrue(ImageHelper.CheckingImagesAreDifferent(screenOne,screenSecond));
            Assert.IsTrue(model.IsValid());           
        }
    }
}
