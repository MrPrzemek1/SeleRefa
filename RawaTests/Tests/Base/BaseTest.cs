using NUnit.Framework;
using RawaTests.Managers;
using static RawaTests.Helpers.DriverHelper.DriverHelper;

namespace RawaTests.Tests.Base
{
    [SetUpFixture]
    public abstract class BaseTest
    {
        protected DriverManager Manager { get; set; }

        public BaseTest()
        {
            
        }
        //public abstract void Init();

        //public abstract void End();
        [OneTimeSetUp]
        public void TestInizialize()
        {
            Manager = DriverManager.CreateInstance();
        }
        [OneTimeTearDown]
        public void EndTest()
        {
            
            Manager.Quit();
        }
        
    }
}
