using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace RawaTests.ContainersModels.StepTwo
{
    public class CanvasWCModel
    {
        public IWebElement CanvasImage { get; set; }
        private IWebDriver Driver;

        public CanvasWCModel(IWebDriver driver, IWebElement canvasImage)
        {
            this.Driver = driver;
            CanvasImage = canvasImage;
        }

        public void OpenColorPickerOnCanvas()
        {
            Actions actions = new Actions(Driver);
            actions.Click(CanvasImage).Perform();
            //CanvasImage.Click();
            actions.SendKeys(Keys.Home).Perform();
        }
    }  
}
