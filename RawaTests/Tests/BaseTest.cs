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
        public virtual void TestInizialize([Values]DriverManager.DriverType type)
        {
            if (type == DriverManager.DriverType.Chrome)
            {
                Manager = DriverManager.CreateInstance(DriverManager.DriverType.Chrome);
            }
            else if (type == DriverManager.DriverType.Firefox)
            {
                Manager = DriverManager.CreateInstance(DriverManager.DriverType.Firefox);
            }
            else if (type == DriverManager.DriverType.Opera)
            {
                Manager = DriverManager.CreateInstance(DriverManager.DriverType.Opera);
            }
            else if (type == DriverManager.DriverType.IE)
            {
                Manager = DriverManager.CreateInstance(DriverManager.DriverType.IE);
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
            Manager.Clear();
            Manager.Quit();
        }
    }
}
