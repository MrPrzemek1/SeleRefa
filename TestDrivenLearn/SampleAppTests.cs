using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestDrivenLearn
{
    [TestClass]
    [TestCategory("TDDPractice")]
    public class SampleAppTests
    {
        private IWebDriver Driver { get; set; }
        public TestUser TestUser { get; set; }

        [TestInitialize]
        public void SetUpForEverySingleTest()
        {
            Driver = GetChromeDriver();
            TestUser = new TestUser();
            TestUser.Name = "Przemek";
            TestUser.LastName = "test";
        }
        [TestMethod]
        public void Test1()
        {
            SetUpForEverySingleTest();
            SampleApplicationPage samplePage = new SampleApplicationPage(Driver);
            samplePage.GoTo();
            Assert.IsTrue(samplePage.IsLoaded, "Sample page was not loaded");

            UltimageQAPage ultimagePage = samplePage.FillOutFormAndSubmit(TestUser);
            Assert.IsTrue(ultimagePage.IsLoaded, "UltimateQA page was not loaded");
        }
        [TestMethod]
        public void Test2()
        {
            SetUpForEverySingleTest();
            SampleApplicationPage samplePage = new SampleApplicationPage(Driver);
            samplePage.GoTo();
            Assert.IsTrue(samplePage.IsLoaded, "Sample page was not loaded");

            UltimageQAPage ultimagePage = samplePage.FillOutFormAndSubmit(TestUser);
            Assert.IsTrue(ultimagePage.IsLoaded, "UltimateQA page was not loaded");
        }
        [TestCleanup]
        public void CleanUpEverySingleTest()
        {
            Driver.Close();
            Driver.Quit();
        }

        private IWebDriver GetChromeDriver()
        {
            return new ChromeDriver();
        }
    }
}
