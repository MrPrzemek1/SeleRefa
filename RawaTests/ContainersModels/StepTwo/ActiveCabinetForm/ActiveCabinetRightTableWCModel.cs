using OpenQA.Selenium;

namespace RawaTests.ContainersModels.StepTwo.ActiveElement
{
    public class ActiveCabinetRightTableWCModel
    {
        public IWebElement bottomLocation { get; set; }
        public IWebElement rotationInput { get; set; }
        public IWebElement rotationButtonDesc { get; set; }
        public IWebElement rotationButtonInc { get; set; }

        public ActiveCabinetRightTableWCModel(IWebElement bottomLocation, IWebElement rotationInput, IWebElement rotationButtonDesc, IWebElement rotationButtonInc)
        {
            this.bottomLocation = bottomLocation;
            this.rotationInput = rotationInput;
            this.rotationButtonDesc = rotationButtonDesc;
            this.rotationButtonInc = rotationButtonInc;
        }
    }
}
