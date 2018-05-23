using OpenQA.Selenium;

namespace RawaTests.ContainersModels.StepTwo.ActiveWindowForm
{
    public class ActiveWindowRightTableWCModel
    {
        public IWebElement bottomLocationHeader { get; set; }
        public IWebElement bottomLocationInput { get; set; }

        public ActiveWindowRightTableWCModel(IWebElement bottomLocationHeader, IWebElement bottomLocationInput)
        {
            this.bottomLocationHeader = bottomLocationHeader;
            this.bottomLocationInput = bottomLocationInput;
        }
    }

}
