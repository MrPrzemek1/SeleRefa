﻿using NUnit.Framework;
using RawaTests.Managers;
using System.IO;

namespace RawaTests.Tests
{
    [SetUpFixture,Category("Rawa")]
    public abstract class BaseTest
    {
        protected DriverManager Manager { get; set; }

        public BaseTest() { }

        private void InizializeManager([Values]DriverType type)
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
            DirectoryInfo di = new DirectoryInfo(@"D:\ScreanshotSelenium");
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            Manager.Quit();
        }
    }
}
