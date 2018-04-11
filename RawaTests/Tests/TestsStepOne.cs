using RawaTests.StepOne;
using NUnit.Framework;
using RawaTests.Tests.Base;
using RawaTests.Services;
using System.Threading;
using RawaTests.Model.StepTwo;
using RawaTests.Services.StepTwoServices;
using RawaTests.Lists;

namespace RawaTests.Tests
{
    [TestFixture(Category ="StepOne")]
    class TestsStepOne : BaseTest
    {
        private HomePageServices homePage;
        private GroupOptionServices optionServices;
        private DimensionServices dimSrv;

        public TestsStepOne()
        {
            homePage = new HomePageServices();
            dimSrv = new DimensionServices();

            optionServices = new GroupOptionServices();
        }
        /// <summary>
        /// Test sprawdzajacy czy po kilknieciu w kształt pomieszczenia jego klasa zmienia sie na active
        /// </summary>
        [Test,Order(1)]
        public void VerifyClickedElementChangeClass()
        {
           
        }

        [Test,Description("Test")]
        public void VerifyingModelRoomSizeAfterChangingDimension()
        {


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
