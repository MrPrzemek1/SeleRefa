using NUnit.Framework;
using RawaTests.Managers;

namespace RawaTests.Tests
{
    [SetUpFixture,Category("Rawa"),]
    public abstract class BaseTest
    {
        protected DriverManager Manager { get; set; }

        public BaseTest()
        {           
        }
        [OneTimeSetUp]
        public virtual void TestInizialize()
        {
            Manager = DriverManager.CreateInstance();
        }
        [OneTimeTearDown]
        public virtual void EndTest()
        {
            Manager.Quit();
        }
    }
}
