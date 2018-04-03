using RawaTests.StepOne;
using NUnit.Framework;
using RawaTests.Tests.Base;
using RawaTests.Services;
using RawaTests.Helpers;
using System.Threading;

namespace RawaTests.Tests
{
    [TestFixture(Category ="StepOne")]
    class TestsStepOne : BaseTest
    {
        private DimensionServices dimensionSrv;

        private HomePageServices homePage;
        public TestsStepOne()
        {
            dimensionSrv = new DimensionServices();
            homePage = new HomePageServices();
        }
        
        public override void End()
        {
            
        }

        public override void Init()
        {
            
        }
        /// <summary>
        /// Test sprawdzajacy czy po kilknieciu w kształt pomieszczenia jego klasa zmienia sie na active
        /// </summary>
        [Test,Order(1)]
        public void VerifyClickedElementChangeClass()
        {
            Thread.Sleep(2000);
            homePage.GetHomePageModel().StartButton.Click();
            var a = dimensionSrv.GetDimensions();           
        }

        [Test,Description("Test sprawdzający czy po kliknięciu w button do zwiększenia wymiarów pomieszczenia zmieniają się wymiary obrazka.")]
        public void VerifyingModelRoomSizeAfterChangingDimension()
        { 
           
        }
        [Test,Description("Test sprawdzający czy po kliknięciu w kształt pomieszczenia zmienia się model obrazka.")]
        public void VerifingyModelChangeAfterClickingOnShape_Positive()
        {
            
        }
        [Test]
        public void VerifingyModelChangeAfterClickingOnShape_Negative()
        {
        }
        
    }
}
