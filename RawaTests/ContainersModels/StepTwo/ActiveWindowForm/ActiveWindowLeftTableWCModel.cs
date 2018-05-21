using OpenQA.Selenium;

namespace RawaTests.ContainersModels.StepTwo.ActiveWindowForm
{
    public class ActiveWindowLeftTableWCModel
    {
        public IWebElement WindowImage { get; set; }
        public IWebElement WindowDimension { get; set; }
        public IWebElement DeleteWindowButton { get; set; }

        public ActiveWindowLeftTableWCModel(IWebElement windowImage, IWebElement windowDimension, IWebElement deleteWindowButton)
        {
            WindowImage = windowImage;
            WindowDimension = windowDimension;
            DeleteWindowButton = deleteWindowButton;
        }
    }
}
