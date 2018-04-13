using OpenQA.Selenium;

namespace RawaTests.WebElementsModels
{
    public class NxWEButtonModel : NxBaseWebElementModel
    {
        private IWebElement element;
        public NxWEButtonModel(IWebElement e) : base(e)
        {
            element = e;
        }      
    }
 }
