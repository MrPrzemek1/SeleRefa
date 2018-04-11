using RawaTests.StepOne;
using NUnit.Framework;
using RawaTests.Tests.Base;
using RawaTests.Services;
using System.Threading;
using RawaTests.Model.StepTwo;
using RawaTests.Services.StepTwoServices;
using RawaTests.Lists;
using System;

namespace RawaTests.Tests
{
    [TestFixture(Category ="StepOne")]
    class TestsStepOne : BaseTest
    {
        private HomePageServices homePage;
        private DimensionServices dimSrv;
        private ShapeRoomServices shapeServices;
        public TestsStepOne()
        {
            homePage = new HomePageServices();
            dimSrv = new DimensionServices();
            shapeServices = new ShapeRoomServices();
        }
        [SetUp]
        public void SetUpStepOneTests()
        {
            homePage.GetHomePageModel().StartButton.Click();
            
        }
        [Test,Category("StepOne"),Order(1)]
        public void VerifyClickedElementChangeClass()
        {
            ShapeRoomPageModel shapes = shapeServices.GetShapes();
            Assert.IsTrue(shapes.ClickingOnTheShapes());
        }

        [Test,Category("StepOne"), Order(2)]
        public void VerifyingModelRoomSizeAfterChangingDimension()
        {


        }
        [Test, Category("StepOne"), Order(3)]
        public void VerifingyModelChangeAfterClickingOnShape_Positive()
        {
            
            
        }
        [Test, Category("StepOne"), Order(4)]
        public void VerifingyModelChangeAfterClickingOnShape_Negative()
        {
        }
        
    }
}
