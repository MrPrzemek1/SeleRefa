using NUnit.Framework;
using RawaTests.Managers;
using System.IO;
using System.Reflection;

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
