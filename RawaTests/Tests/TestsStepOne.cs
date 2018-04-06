using RawaTests.StepOne;
using NUnit.Framework;
using RawaTests.Tests.Base;
using RawaTests.Services;
using RawaTests.Helpers;
using System.Threading;
using System.Linq;
using RawaTests.Model.StepTwo;
using static RawaTests.Helpers.DriverHelper.DriverHelp;
using OpenQA.Selenium;
using RawaTests.Services.StepTwoServices;
using System.Drawing;
using RawaTests.Lists;
using static RawaTests.Models.StepTwo.Groups.GroupOptionPageModel;

namespace RawaTests.Tests
{
    [TestFixture(Category ="StepOne")]
    class TestsStepOne : BaseTest
    {
        private HomePageServices homePage;
        private StepOneFacade StepOneFcd;
        private GroupOptionServices optionServices;
        public TestsStepOne()
        {
            homePage = new HomePageServices();
            StepOneFcd = FacadeBuilder.GetStepOneFacade();

            optionServices = new GroupOptionServices();
        }

        public override void End() { }

        public override void Init()
        {
            homePage.GetHomePageModel().StartButton.Click();
        }
        /// <summary>
        /// Test sprawdzajacy czy po kilknieciu w kształt pomieszczenia jego klasa zmienia sie na active
        /// </summary>
        [Test,Order(1)]
        public void VerifyClickedElementChangeClass()
        {
            ShapeRoomPageModel shapes = StepOneFcd.GetShapes();
            shapes.ClickShapeById("28");
            DimensionsPageModel dim = StepOneFcd.GetDimensions();
            dim.GetFieldByDescription("A").PlusSign.Click();
            DimensionsPageModel dim2 = StepOneFcd.GetDimensions();
            dim2.GetFieldByDescription("E").PlusSign.Click();
            Assert.AreEqual("wallSizeInput changed", dim2.GetFieldByDescription("A").Input.GetAttribute("class"));
        }

        [Test,Description("Test")]
        public void VerifyingModelRoomSizeAfterChangingDimension()
        {

            //stepOne.GetFullModel().Shapes.GetShapes().GetShapeById("28");
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath("//html//div[@class='roomForm-container']//li[1]"));

            //ButtonHelper.ClickButtonNext();
            var a = Driver.FindElements(By.XPath("//html//div[@class='roomForm-container']//li"));
            //var b = a.GetAttribute("class");
            Thread.Sleep(1000);


        }
        [Test,Description("Test 2")]
        public void VerifingyModelChangeAfterClickingOnShape_Positive()
        {
            Thread.Sleep(2000);
          var a = Driver.FindElements(By.XPath("//html//div[@class='roomForm-container']//li"));
            foreach(var element in a)
            {
                var labelWE = element.FindElement(By.XPath("//label[@class='set-room-params-letters']"));
                var btnPlusWE = element.FindElement(By.XPath("//label[@class='set-room-params-letters']"));
                var btnMinusWE = element.FindElement(By.XPath("//label[@class='set-room-params-letters']"));
                var inputWE = element.FindElement(By.XPath("//label[@class='set-room-params-letters']"));
                if(!string.IsNullOrEmpty(labelWE.Text))
                {
                    new DimensionModel()
                }
            }
          
        }
        [Test]
        public void VerifingyModelChangeAfterClickingOnShape_Negative()
        {
        }
        
    }
}
