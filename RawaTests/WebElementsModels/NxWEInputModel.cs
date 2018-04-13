using OpenQA.Selenium;

namespace RawaTests.WebElementsModels
{
    public class NxWEInputModel : NxBaseWebElementModel
    {
        private IWebElement element;
        public NxWEInputModel(IWebElement e) : base(e)
        {
            element = e;
        }
        public void Clear()
        {
            element.Clear();
        }
        public void SendText(string text)
        {
            element.SendKeys(text);
        }
    }
}
