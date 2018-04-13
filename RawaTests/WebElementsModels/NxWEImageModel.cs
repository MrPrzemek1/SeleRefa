using OpenQA.Selenium;

namespace RawaTests.WebElementsModels
{
    public class NxWEImageModel : NxBaseWebElementModel
    {

        private IWebElement element;
        public NxWEImageModel(IWebElement element) : base (element)
        {
            this.element = element;
        }
        public string GetImageSource()
        {
            return element.GetAttribute("src");
        }
        public string GetElementAttribute(string attributeName)
        {
            return element.GetAttribute(attributeName);
        }
        public override void Click()
        {
            element.Click();           
        }
    }
}
