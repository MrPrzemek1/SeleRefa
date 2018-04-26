using NUnit.Framework;
using RawaTests.Managers;
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
            if (Manager==null || Manager.Type!=type)
            {
                Manager = new DriverManager(type);
            }
            Manager.Initialize();
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
