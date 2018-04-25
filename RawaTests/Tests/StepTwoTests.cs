using NUnit.Framework;
using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo;
using RawaTests.Helpers;
using RawaTests.Managers;
using RawaTests.Services;
using RawaTests.Services.StepTwoServices;
using RawaTests.Services.StepTwoServices.PanelListForCabinets;
using RawaTests.StepOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RawaTests.Tests
{
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
            groupOptionServices = new GroupOptionWCServices(Manager);
            leftPanelServices = new LeftTableStepTwoWCServices(Manager);
            canvasServices = new CanvasWCServices(Manager);
            activeElementServices = new ActiveElementFormWCServices(Manager);
            colorPickerServices = new ColorPickerServies(Manager);
            homeServices = new HomePageWCServices(Manager);
            shapeRoomServices = new ShapeRoomWCServices(Manager);
        }
        [Test, Order(1)]
        public void ChangesFloorColorUsingColorPallete()
        {
            homeServices.GetHomePageModel().StartButton.ClickIfElementIsClickable();
            ButtonHelper.ClickButtonNext();
            string pathfirst = ImageHelper.MakeScreenshot();
            var canvas = canvasServices.GetCanvasModel();
            canvas.OpenColorPickerOnCanvas();
            ColorPickerWCModel colorpicker = colorPickerServices.GetFullColorPickerModel();
            colorpicker.allColors.GetRandomColor();
            colorpicker.rightPanel.SubmitButton.ClickIfElementIsClickable();
            string pathsecond = ImageHelper.MakeScreenshot();

            Assert.IsTrue(ImageHelper.CheckingImagesAreDifferent(pathfirst, pathsecond));
        }
        [Test, Order(2)]
        public void ChangeColorUsingColorSlider()
        {
            string pathfirst = ImageHelper.MakeScreenshot();
            var canvas = canvasServices.GetCanvasModel();
            canvas.OpenColorPickerOnCanvas();
            ColorPickerWCModel colorpicker = colorPickerServices.GetFullColorPickerModel();
            colorpicker.rightPanel.ColorSlider.ChangeColorWithSlider(50);
            colorpicker.rightPanel.SubmitButton.ClickIfElementIsClickable();
            string pathsecond = ImageHelper.MakeScreenshot();

            Assert.IsTrue(ImageHelper.CheckingImagesAreDifferent(pathfirst, pathsecond));
        }
        [Test, Order(3)]
        public void ChangeColorUsingColorSquare()
        {
            //ClearBasket();
            string pathfirst = ImageHelper.MakeScreenshot();
            var canvas = canvasServices.GetCanvasModel();
            canvas.OpenColorPickerOnCanvas();
            ColorPickerWCModel colorpicker = colorPickerServices.GetFullColorPickerModel();
            colorpicker.rightPanel.ChangeColorWithSquare();
            colorpicker.rightPanel.SubmitButton.Click();
            string pathsecond = ImageHelper.MakeScreenshot();

            Assert.IsTrue(ImageHelper.CheckingImagesAreDifferent(pathfirst, pathsecond));
        }
        [Test, Order(4)]
        public void DragAndDropDoors()
        {
            ClearBasket();
            groupOptionServices.GetOptionModel().GetOptionDoor();
            IWebElement door = leftPanelServices.GetPanelForDoors().GetRandomDoor();
            IWebElement canvas = canvasServices.GetCanvasModel().CanvasImage;
            ActionsManager.CreateAction().RotateElement(canvas);
            ActionsManager.CreateAction().CustomDragAndDropForWindowAndDoor(door, canvas);
            Assert.IsTrue(activeElementServices.GetActiveDoorForm().IsValid());
        }
        [Test,Order(5)]
        public void RemoveActiveDoors()
        {
            activeElementServices.GetActiveDoorForm().DeleteButton.ClickIfElementIsClickable();
            DriverManager.CreateInstance().AcceptAlert();
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
        public void DragAndDropWindows()
        {
            //ClearBasket();
            groupOptionServices.GetOptionModel().GetOptionWindow();
            IWebElement door = leftPanelServices.GetPanelForWindow().GetRandomWindow();
            IWebElement canvas = canvasServices.GetCanvasModel().CanvasImage;
            //ActionsManager.CreateAction().RotateElement(canvas);
            ActionsManager.CreateAction().CustomDragAndDropForWindowAndDoor(door, canvas);
            Assert.IsTrue(activeElementServices.GetActiveDoorForm().IsValid());
        }
        [Test, Order(7)]
        public void RemoveActiveWindow()
        {
            activeElementServices.GetFullActiveWindowWCModel().leftTableWCModel.DeleteWindowButton.ClickIfElementIsClickable();
            DriverManager.CreateInstance().AcceptAlert();
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
        public void VerifyRotateCabinetUsingInput()
        {
            groupOptionServices.GetOptionModel().GetOptionCabinetsSimply();
            IWebElement cabinets = leftPanelServices.GetSimplyLowerCabintesModel().ImagesOfCabinets;
            IWebElement canvas = canvasServices.GetCanvasModel().CanvasImage;             
            ActionsManager.CreateAction().RotateElement(canvas, -200, 100);
            ActionsManager.CreateAction().CustomDragAndDropForCabinets(cabinets, canvas, 20, 20);
            string screenOne = ImageHelper.MakeScreenshot();
            var model = activeElementServices.GetActiveCabinetModel();
            model.RightPanel.RotationInput.SendKeys("2");
            ActionsManager.CreateAction().Click(model.LeftPanel.CabinetImageThumb).Build().Perform();
            string screenSecond = ImageHelper.MakeScreenshot();

            Assert.IsTrue(ImageHelper.CheckingImagesAreDifferent(screenOne, screenSecond));
            Assert.IsTrue(model.IsValid());
        }

        public static void ClearBasket()
        {
            ButtonHelper.ClickButtonPrev();
            DimensionWCServices dimension = new DimensionWCServices(DriverManager.CreateInstance());
            dimension.GetDimensions().GetFieldByDescription("A").PlusSign.ClickIfElementIsClickable();
            DriverManager.CreateInstance().AcceptAlert();
            ButtonHelper.ClickButtonNext();
        }
        
    }
}
