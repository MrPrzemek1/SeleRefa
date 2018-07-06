using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObjectPattern.Tests
{
    ////[TestFixture]
    //class SecondTest : BaseTest
    //{
    //    public SecondTest() : base()
    //    {

    //    }
    //    private IWebDriver driver;
    //    public SecondTest(IWebDriver driver) :base(driver)
    //    {
    //        this.driver = driver;
    //    }
    //    //[Test, Category("asd")]
    //    public void lalala()
    //    {
    //        driver.FindElement(By.XPath("//html//div[2]/label[4]")).Click();
    //        Thread.Sleep(2000);
    //        Actions actions = new Actions(driver);
    //        var source = driver.FindElement(By.XPath("//div[@id='yes-drop']"));
    //        var target = driver.FindElement(By.XPath("//div[@id='inner-dropzone']"));
    //        actions.DragAndDropToOffset(source, 804, 769).Perform();
    //        actions.DragAndDrop(source, target).Perform();
    //    }
    //}
}
