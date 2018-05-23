using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace TestDrivenLearn
{
    [TestClass]
    [TestCategory("TDDPractice")]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver();
            var complicatedPage = new ComplicatedPage(driver);
            complicatedPage.Open();
            complicatedPage.SearchUsingAmazon("automation testing");
        }
    }
}
