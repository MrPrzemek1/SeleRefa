using NUnit.Framework;
using RawaTests.ContainersModels.Home;
using RawaTests.Helpers;
using RawaTests.Lists;
using RawaTests.Model;
using RawaTests.Model.Room3D;
using RawaTests.Services;
using RawaTests.Services.StepTwoServices;
using RawaTests.StepOne;
using RawaTests.ValidateMessages;
using OpenQA.Selenium;
using System.Linq;
using RawaTests.Services.StepTwoServices.PanelListForCabinets;

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
        GroupOptionServices groupOptionServices;
        PanelListCabinetsServices panelListCabinetsServices;
        public AllTests()
        {
            homeServices = new HomePageWCServices();
            loginServices = new LoginPageWCServices();
            dimensionServices = new DimensionWCServices();
            shapeServices = new ShapeRoomServices();
            roomViewServices = new Room3DServices();
            groupOptionServices = new GroupOptionServices();
            panelListCabinetsServices = new PanelListCabinetsServices();
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

            ActionOnWCLoginPage loginPage = loginServices.GetLoginPageModel();
            loginPage.SetCorrectLoginData();
            loginPage.SubmitButton.Click();
            ActionOnWCHomePage homePageAfterLogin = homeServices.GetHomePageModel();
            Assert.IsTrue(homePageAfterLogin.LogoutDiv.Displayed);
            Assert.IsTrue(homePageAfterLogin.LogoutDiv.Text.Equals(ValidateTextsHelper.CorrectLoginText));
        }

        [Test, Order(3)]
        public void VerifyingValidateTextWhenCompanyNameIsEmpty()
        {
            homeServices.GetHomePageModel().LogoutButton.Click();
            Manager.Driver.SwitchTo().Alert().Accept();
            homeServices.GetHomePageModel().LoginBtn.Click();

            ActionOnWCLoginPage loginPage = loginServices.GetLoginPageModel();
            loginPage.LoginInput.SendKeys("Test");
            loginPage.PasswordInput.SendKeys("test");
            loginPage.SubmitButton.Click();
            ActionOnWCLoginPage loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateFieldIsDisplayed);
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.CompanyValidateText));
        }
        [Test, Order(4)]
        public void VerifingValidateTextWhenUserNameIsEmpty()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.Click();
            ActionOnWCLoginPage loginPage = loginServices.GetLoginPageModel();
            loginPage.CompanyNameInput.SendKeys("lalala");
            loginPage.PasswordInput.SendKeys("lalala");
            loginPage.SubmitButton.Click();
            ActionOnWCLoginPage loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.LoginValidateText));
        }
        [Test, Order(5)]
        public void VerifingValidateTextPasswordFieldIsEmpty()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.Click();
            ActionOnWCLoginPage loginPage = loginServices.GetLoginPageModel();
            loginPage.CompanyNameInput.SendKeys("lalala");
            loginPage.LoginInput.SendKeys("lalala");
            loginPage.SubmitButton.Click();
            ActionOnWCLoginPage loginAfterSubmit = loginServices.GetLoginPageModel();
            Assert.IsTrue(loginAfterSubmit.ValidateText.Equals(ValidateTextsHelper.PasswordValidateText));
        }
        [Test, Order(6)]
        public void VerifingValidateTextWhenLoginDataWasIncorrect()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().LoginBtn.Click();
            ActionOnWCLoginPage loginPage = loginServices.GetLoginPageModel();
            loginPage.SetLoginData("Test", "Test", "Test");
            loginPage.SubmitButton.Click();
            ActionOnWCLoginPage loginAfterSubmit = loginServices.GetLoginPageModel();
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
            Rooms3DWCModel roomView = roomViewServices.Get3DModel();
            var dimensionRoomView = roomView.GetRoomDimension();
            shapes.ClickShapeById("28");
            Rooms3DWCModel roomAfterChangeShape = roomViewServices.Get3DModel();
            var dimensionAfterChangeShape = roomAfterChangeShape.GetRoomDimension();
            Assert.AreNotSame(roomView.GetRoomDimension(), roomAfterChangeShape.GetRoomDimension());
            Assert.AreNotEqual(dimensionRoomView, dimensionAfterChangeShape);
        }
        [Test, Order(9)]
        public void VerifingySizeOfRoomModelChangeAfterChangeDimension()
        {
            Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().StartButton.Click();

            Rooms3DWCModel roomModel = roomViewServices.Get3DModel();
            var roomDimension = roomModel.GetRoomDimension();
            DimensionsWCModel dimensionOfRoom = dimensionServices.GetDimensions();
            dimensionOfRoom.GetFieldByDescription("B").PlusSign.Click();
            Rooms3DWCModel roomModelAfterChange = roomViewServices.Get3DModel();
            var roomDimensionAfterChange = roomModelAfterChange.GetRoomDimension();

            Assert.AreNotEqual(roomDimension, roomDimensionAfterChange);
        }
        [Test, Order(10)]
        public void CheckingTheClassChangeForTheElementAfterChangingTheDimensionsOnTheDependentWall()
        {
            // Manager.Driver.Navigate().Refresh();
            homeServices.GetHomePageModel().StartButton.Click();

            ButtonHelper.ClickButtonNext();
            var a = groupOptionServices.GetOptionModel();
            a.GetOptionCabinetsSimple();
            var b = panelListCabinetsServices.GetCabintesCollectionModel();

        }

    }
}
