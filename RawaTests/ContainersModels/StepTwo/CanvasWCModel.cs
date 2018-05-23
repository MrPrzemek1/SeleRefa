using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace RawaTests.ContainersModels.StepTwo
{
    public class CanvasWCModel
    {
        private IWebDriver _driver;
        public IWebElement canvasImage { get; set; }

        public CanvasWCModel(IWebDriver driver, IWebElement canvasImage)
        {
            this._driver = driver;
            this.canvasImage = canvasImage;
        }

        public void OpenColorPickerOnCanvas()
        {
            Actions actions = new Actions(_driver);
            actions.Click(canvasImage).Perform();
            //CanvasImage.Click();
            actions.SendKeys(Keys.Home).Perform();
        }
    }  
}
