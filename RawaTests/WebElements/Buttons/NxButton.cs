using OpenQA.Selenium;
using RawaTests.IWebElements;

namespace RawaTests.Model.Base.Buttons
{
    public class NxButton : BaseWebElement, INxButton
    {
        private IWebElement element;
        public NxButton(IWebElement e) : base(e)
        {
            element = e;
        }
        public void Click()
        {
            element.Click();
        }
    }
}
