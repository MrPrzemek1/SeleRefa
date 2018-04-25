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
            Manager = DriverManager.CreateInstance();
        }
        [OneTimeSetUp]
        public virtual void TestInizialize()
        {
            Manager.Initialize();
        }
        [OneTimeTearDown]
        public virtual void EndTest()
        {
            DirectoryInfo di = new DirectoryInfo(@"E:\ScreanshotSelenium");
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            Manager.Clear();
            Manager.Quit();
        }
    }
}
