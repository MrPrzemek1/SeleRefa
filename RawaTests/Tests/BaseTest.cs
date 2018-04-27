using NUnit.Framework;
using RawaTests.Managers;
using RawaTests.Services.Builder;
using System.IO;
using System.Reflection;

namespace RawaTests.Tests
{
    [SetUpFixture,Category("Rawa")]
    public abstract class BaseTest
    {
        protected DriverManager Manager { get; set; }

        public BaseTest()
        {
            
        }
        public virtual void InizializeManager([Values]DriverType type)
        {
            Manager = new DriverManager(type);
            Manager.Initialize();
        }
        public virtual void Init(DriverType type)
        {
            InizializeManager(type);
        }
        [TearDown]
        public virtual void EndTest()
        {
            DirectoryInfo di = new DirectoryInfo(@"E:\ScreanshotSelenium");
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            Manager.Quit();
        }
    }
}
