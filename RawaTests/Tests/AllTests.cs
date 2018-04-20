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

namespace RawaTests.Tests
{
    [TestFixture]
    class AllTests : BaseTest
    {
        HomePageWCServices homeServices;
        LoginPageWCServices loginServices;
        private DimensionWCServices dimensionServices;
        private ShapeRoomServices shapeServices;
        private Room3DServices roomViewServices;
        GroupOptionWCServices groupOptionServices;
        PanelCabinetsWCServices panelCabinetsServices;
        CanvasWCServices canvasServices;
        ActiveCabinetWCServices activeCabinetServices;
        public AllTests()
        {
            homeServices = new HomePageWCServices();
            loginServices = new LoginPageWCServices();
            dimensionServices = new DimensionWCServices();
            shapeServices = new ShapeRoomServices();
            roomViewServices = new Room3DServices();
            groupOptionServices = new GroupOptionWCServices();
            panelCabinetsServices = new PanelCabinetsWCServices();
            canvasServices = new CanvasWCServices();
            activeCabinetServices = new ActiveCabinetWCServices();
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

            LoginPageWCModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetCorrectLoginData();
            loginPage.SubmitButton.Click();
            HomePageWCModel homePageAfterLogin = homeServices.GetHomePageModel();
            Assert.IsTrue(homePageAfterLogin.LogoutDiv.Displayed);
            Assert.IsTrue(homePageAfterLogin.LogoutDiv.Text.Equals(ValidateTextsHelper.CorrectLoginText));
        }

        [Test, Order(3)]
        public void VerifyingValidateTextWhenCompanyNameIsEmpty()
        {
            homeServices.GetHomePageModel().LogoutButton.Click();
            Manager.Driver.SwitchTo().Alert().Accept();
            homeServices.GetHomePageModel().LoginBtn.Click();

            LoginPageWCModel loginPage = loginServices.GetLoginPageModel();
            loginPage.LoginInput.SendKeys("Test");
            loginPage.PasswordInput.SendKeys("test");
            loginPage.SubmitButton.Click();
            LoginPageWCModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateFieldIsDisplayed);
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.CompanyValidateText));
        }
        [Test, Order(4)]
        public void VerifingValidateTextWhenUserNameIsEmpty()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.Click();
            LoginPageWCModel loginPage = loginServices.GetLoginPageModel();
            loginPage.CompanyNameInput.SendKeys("lalala");
            loginPage.PasswordInput.SendKeys("lalala");
            loginPage.SubmitButton.Click();
            LoginPageWCModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.LoginValidateText));
        }
        [Test, Order(5)]
        public void VerifingValidateTextPasswordFieldIsEmpty()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.Click();
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
            homeServices.GetHomePageModel().LoginBtn.Click();
            LoginPageWCModel loginPage = loginServices.GetLoginPageModel();
            loginPage.SetLoginData("Test", "Test", "Test");
            loginPage.SubmitButton.Click();
            LoginPageWCModel loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.ErrorValidateText));
        }
        [Test, Order(7)]
        public void VerifyClickedElementChangeClass()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().StartButton.Click();

            ShapesRoomWCModel shapes = shapeServices.GetShapes();
            Assert.IsTrue(shapes.ClickingOnTheShapes());
        }
        [Test, Order(8)]
        public void VerifyingModelRoomChangeAfterChangeShape()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().StartButton.Click();

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
            homeServices.GetHomePageModel().StartButton.Click();

            Room3DWCModel roomModel = roomViewServices.Get3DModel();
            var roomDimension = roomModel.Room3dImageDimension;
            DimensionsWCModel dimensionOfRoom = dimensionServices.GetDimensions();
            dimensionOfRoom.GetFieldByDescription("B").PlusSign.Click();
            Room3DWCModel roomModelAfterChange = roomViewServices.Get3DModel();
            var roomDimensionAfterChange = roomModelAfterChange.Room3dImageDimension;

            Assert.AreNotEqual(roomDimension, roomDimensionAfterChange);
        }
        [Test, Order(10)]
        public void CheckingTheClassChangeForTheElementAfterChangingTheDimensionsOnTheDependentWall()
        {
            // Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().StartButton.Click();
            ButtonHelper.ClickButtonNext();
            var options = groupOptionServices.GetOptionModel();
            options.GetOptionCabinetsSimply();
            var simplyLower = panelCabinetsServices.GetSimplyLowerCabintesModel();
            var canvas = canvasServices.GetCanvasModel().CanvasImage;
            
            ImageHelper.MakeScreenshot(PathConsts.SCREENONE);

            Actions action = new Actions(DriverManager.CreateInstance().Driver);

            action.ClickAndHold(simplyLower.ImagesOfCabinets).MoveByOffset(585, 207).Perform();
            action.Release(canvas).Build().Perform();
            Thread.Sleep(1000);
            action.DragAndDrop(simplyLower.ImagesOfCabinets, canvas).Perform();
            Thread.Sleep(1000);
            action.Release(canvas).Build().Perform();

            ActiveCabinetFullWCModel model = activeCabinetServices.GetActiveCabinetModel();
            
            ImageHelper.MakeScreenshot(PathConsts.SCREENTWO);
            Assert.IsTrue(ImageHelper.CheckingImagesAreDifferent());
            //Assert.IsFalse(ImageHelper.ImageCompare(bitMapFromScreenOne, bitMapFromScreenOne, 3));
            File.Delete(PathConsts.SCREENONE);
            File.Delete(PathConsts.SCREENTWO);
        }

    }
}
