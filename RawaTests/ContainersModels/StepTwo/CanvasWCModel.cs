using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace RawaTests.ContainersModels.StepTwo
{
    public class CanvasWCModel
    {
        private IWebDriver _driver;
        public IWebElement CanvasImage { get; set; }

        public CanvasWCModel(IWebDriver driver, IWebElement canvasImage)
        {
            this._driver = driver;
            this.CanvasImage = canvasImage;
        }

        public void OpenColorPickerOnCanvas()
        {
            Actions actions = new Actions(_driver);
            actions.Click(CanvasImage).Perform();
            //CanvasImage.Click();
            actions.SendKeys(Keys.Home).Perform();
        }
    }  
}
