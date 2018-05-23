using OpenQA.Selenium;

namespace RawaTests.ContainersModels.StepTwo.ActiveWindowForm
{
    public class ActiveWindowLeftTableWCModel
    {
        public IWebElement windowImage { get; set; }
        public IWebElement windowDimension { get; set; }
        public IWebElement deleteWindowButton { get; set; }

        public ActiveWindowLeftTableWCModel(IWebElement windowImage, IWebElement windowDimension, IWebElement deleteWindowButton)
        {
            this.windowImage = windowImage;
            this.windowDimension = windowDimension;
            this.deleteWindowButton = deleteWindowButton;
        }
    }
}
