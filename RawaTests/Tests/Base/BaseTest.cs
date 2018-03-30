using NUnit.Framework;
using OpenQA.Selenium;
using RawaTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestyRawa.DriverHelper;

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
            Browser.Initialize();
            Init();
        }
        [OneTimeTearDown]
        public void EndTest()
        {
            End();
            Browser.Quit();
        }
        
    }
}
