using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestyRawa.DriverHelper;

namespace TestyRawa
{
    [TestFixture]
    class StepOneTests : StepOneShapes
    {
        [OneTimeSetUp]
        public void TestInizialize()
        {
            Browser.Initialize();
            Browser.ClickOnElement(By.XPath("//button[@class='btn btn-primary btn-lg btn-start']"));
        }
        [OneTimeTearDown]
        public void EndTest()
        {
            Browser.Quit();
        }
        [Test,Description("Sprawdzenie czy po kliknięciu w obrazek kształtu pomieszczenia jest on aktywny"),Order(1)]
        public void VerifyChangeClassForShapes()
        {
           Assert.IsTrue(ViewRoomList());
        }

        [Test, Description("Sprawdzenie czy po kliknieciu na przycisk + i zmianie wartości w pole inne pole zależne od niego również zmienia wartość."), Order(2)]
        public void CheckingClassChangeInTheDependentWall()
        {
            ClickOnMinusButtonToTheFieldWithSizeOfWall(1,0);
            Assert.AreEqual("wallSizeInput changed", Browser.GetElementAttribute(By.XPath("//input[@name='3' and @type='number']"), "class"));
        }
        [Test, Description("Sprawdzenie czy po kliknieciu zmianie rozmiaru sciany zmieniaja sie wymiary obrazka pogladowego"), Order(3)]
        public void CheckingChangeSizeOfShapeImage()
        {
            List<string> DefaultDimensionList = GetDimensionImageSize();     
            //ClickOnMinusButtonToTheFieldWithSizeOfWall(0,0);
            List<string> DemensionAfterChanges = GetDimensionImageSize();
            Assert.IsTrue(CompareImageDimension(DefaultDimensionList, DemensionAfterChanges));
        }
    }
}
