using NUnit.Framework;
using static RawaTests.Helpers.DriverHelper.DriverHelp;

namespace RawaTests.Tests.Base
{
    [SetUpFixture]
    public abstract class BaseTest
    {
        public BaseTest()
        {
            
        }
        public abstract void Init();

        public abstract void End();
        [OneTimeSetUp]
        public void TestInizialize()
        {
            Initialize();
            Init();
        }
        [OneTimeTearDown]
        public void EndTest()
        {
            End();
            Quit();
        }
        
    }
}
