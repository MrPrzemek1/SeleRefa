using NUnit.Framework;
using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo;
using RawaTests.Helpers;
using RawaTests.Managers;
using RawaTests.Services;
using RawaTests.Services.Builder;
using RawaTests.Services.StepTwoServices;
using RawaTests.Services.StepTwoServices.PanelListForCabinets;
using RawaTests.StepOne;
using System;

namespace RawaTests.Tests
{
    [TestFixtureSource(typeof(DriverManager), "DriverType")]
    [TestFixture, Category("Rawa")]
    class StepTwoTests : BaseTest
    {
        GroupOptionWCServices groupOptionServices;
        LeftTableStepTwoWCServices leftPanelServices;
        CanvasWCServices canvasServices;
        ActiveElementFormWCServices activeElementServices;
        ColorPickerServies colorPickerServices;
        HomePageWCServices homeServices;
        ShapeRoomWCServices shapeRoomServices;

        public StepTwoTests() : base()
        {
            
        }
        public override void Init(DriverType type)
        {
            base.Init(type);
            groupOptionServices = new GroupOptionWCServices(Manager);
            leftPanelServices = new LeftTableStepTwoWCServices(Manager);
            canvasServices = new CanvasWCServices(Manager);
            activeElementServices = new ActiveElementFormWCServices(Manager);
            colorPickerServices = new ColorPickerServies(Manager);
            homeServices = new HomePageWCServices(Manager);
            shapeRoomServices = new ShapeRoomWCServices(Manager);
        }
        [Test, Order(1)]
        public void ChangesFloorColorUsingColorPallete([Values]DriverType type)
        {
            Init(type);
            GoToSecondStep();          
            string pathfirst = ImageHelper.MakeScreenshot(Manager.Driver);
            ColorPickerWCModel colorpicker = GetColorPicker();
            colorpicker.allColors.GetRandomColor();
            colorpicker.rightPanel.SubmitButton.ClickIfElementIsClickable(Manager.Driver);
            string pathsecond = ImageHelper.MakeScreenshot(Manager.Driver);

            Assert.IsTrue(ImageHelper.CheckingImagesAreDifferent(pathfirst, pathsecond));
        }


        [Test, Order(2)]
        public void ChangeColorUsingColorSlider([Values]DriverType type)
        {
            Init(type);
            GoToSecondStep();
            string pathfirst = ImageHelper.MakeScreenshot(Manager.Driver);
            ColorPickerWCModel colorpicker = GetColorPicker();
            colorpicker.rightPanel.ColorSlider.ChangeColorWithSlider(50);
            colorpicker.rightPanel.SubmitButton.ClickIfElementIsClickable(Manager.Driver);
            string pathsecond = ImageHelper.MakeScreenshot(Manager.Driver);

            Assert.IsTrue(ImageHelper.CheckingImagesAreDifferent(pathfirst, pathsecond));
        }
        [Test, Order(3)]
        public void ChangeColorUsingColorSquare([Values]DriverType type)
        {
            GoToSecondStep();
            Init(type);
            string pathfirst = ImageHelper.MakeScreenshot(Manager.Driver);
            ColorPickerWCModel colorpicker = GetColorPicker();
            colorpicker.rightPanel.ChangeColorWithSquare();
            colorpicker.rightPanel.SubmitButton.Click();
            string pathsecond = ImageHelper.MakeScreenshot(Manager.Driver);

            Assert.IsTrue(ImageHelper.CheckingImagesAreDifferent(pathfirst, pathsecond));
        }
        [Test, Order(4)]
        public void DragAndDropDoors([Values]DriverType type)
        {
            Init(type);
            GoToSecondStep();         
            DragAndDropDoor();
            Assert.IsTrue(activeElementServices.GetActiveDoorForm().IsValid());
        }

        [Test, Order(5)]
        public void RemoveActiveDoors([Values]DriverType type)
        {
            Init(type);
            GoToSecondStep();          
            DragAndDropDoor();
            activeElementServices.GetActiveDoorForm().DeleteButton.ClickIfElementIsClickable(Manager.Driver);
            Manager.AcceptAlert();
            try
            {
                Assert.IsTrue(activeElementServices.GetActiveDoorForm().IsValid());

            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "test zaliczony");
            }
        }

        [Test, Order(6)]
        public void DragAndDropWindows([Values]DriverType type)
        {
            Init(type);
            GoToSecondStep();
            DragAndDropWindow();
            Assert.IsTrue(activeElementServices.GetActiveDoorForm().IsValid());
        }

        [Test, Order(7)]
        public void RemoveActiveWindow([Values]DriverType type)
        {
            Init(type);
            GoToSecondStep();
            DragAndDropWindow();
            activeElementServices.GetFullActiveWindowWCModel().leftTableWCModel.DeleteWindowButton.ClickIfElementIsClickable(Manager.Driver);
            Manager.AcceptAlert();
            try
            {
                Assert.IsTrue(activeElementServices.GetFullActiveWindowWCModel().IsValid());

            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "test zaliczony");
            }
        }

        [Test, Order(8)]
        public void VerifyRotateCabinetUsingInput([Values]DriverType type)
        {
            Init(type);
            GoToSecondStep();
            groupOptionServices.GetOptionModel().GetOptionCabinetsSimply();
            IWebElement cabinets = leftPanelServices.GetSimplyLowerCabintesModel().ImagesOfCabinets;
            IWebElement canvas = canvasServices.GetCanvasModel().CanvasImage;
            ActionManager.Create(Manager.Driver).CustomDragAndDropForCabinets(cabinets, canvas, 20, 20);
            string screenOne = ImageHelper.MakeScreenshot(Manager.Driver);
            var model = activeElementServices.GetActiveCabinetModel();
            model.RightPanel.RotationInput.SendKeys("20");
            ActionManager.Create(Manager.Driver).Click(model.LeftPanel.CabinetImageThumb).Build().Perform();
            string screenSecond = ImageHelper.MakeScreenshot(Manager.Driver);

            Assert.IsTrue(ImageHelper.CheckingImagesAreDifferent(screenOne, screenSecond));
            Assert.IsTrue(model.IsValid());
        }

        //private void ClearBasket()
        //{
        //    ButtonHelper.ClickButtonPrev(Manager.Driver);
        //    DimensionWCServices dimension = new DimensionWCServices(Manager);
        //    dimension.GetDimensions().GetFieldByDescription("A").PlusSign.ClickIfElementIsClickable(Manager.Driver);
        //    //DriverManager.AcceptAlert();
        //    ButtonHelper.ClickButtonNext(Manager.Driver);
        //}
        #region HelpersMethod
    
        private void GoToSecondStep()
        {
            homeServices.GetHomePageModel().StartButton.ClickIfElementIsClickable(Manager.Driver);
            ButtonHelper.ClickButtonNext(Manager.Driver);
        }

        private void DragAndDropDoor()
        {
            groupOptionServices.GetOptionModel().GetOptionDoor();
            IWebElement door = leftPanelServices.GetPanelForDoors().GetRandomDoor();
            IWebElement canvas = canvasServices.GetCanvasModel().CanvasImage;
            ActionManager.Create(Manager.Driver).RotateElement(canvas);
            ActionManager.Create(Manager.Driver).CustomDragAndDropForWindowAndDoor(door, canvas);
        }

        private ColorPickerWCModel GetColorPicker()
        {
            var canvas = canvasServices.GetCanvasModel();
            canvas.OpenColorPickerOnCanvas();
            ColorPickerWCModel colorpicker = colorPickerServices.GetFullColorPickerModel();
            return colorpicker;
        }

        private void DragAndDropWindow()
        {
            groupOptionServices.GetOptionModel().GetOptionWindow();
            IWebElement window = leftPanelServices.GetPanelForWindow().GetRandomWindow();
            IWebElement canvas = canvasServices.GetCanvasModel().CanvasImage;
            ActionManager.Create(Manager.Driver).RotateElement(canvas);
            ActionManager.Create(Manager.Driver).CustomDragAndDropForWindowAndDoor(window, canvas);
        }
        #endregion
    }
}
