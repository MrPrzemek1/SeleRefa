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
        
        public override void End()
        {
            
        }

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
            DimensionsPageModel dim = StepOneFcd.GetDimensions();

            dim.GetFieldByDescription("A").PlusSign.Click();
           
            //var a = dimensionSrv.GetDimensions();
            //a.GetFieldByDescription("E").PlusSign.Click();
            //Assert.AreEqual("wallSizeInput changed", a.GetFieldByDescription("A").Input.GetAttribute("class"));            
        }

        [Test,Description("Test")]
        public void VerifyingModelRoomSizeAfterChangingDimension()
        {
            
            //stepOne.GetFullModel().Shapes.GetShapes().GetShapeById("28");
            ButtonHelper.ClickButtonNext();
            var b = optionServices.GetOptionModel();
            Assert.IsTrue(b.atr());           
        }
        [Test,Description("Test 2")]
        public void VerifingyModelChangeAfterClickingOnShape_Positive()
        {
            
        }
        [Test]
        public void VerifingyModelChangeAfterClickingOnShape_Negative()
        {
        }
        
    }
}
