using OpenQA.Selenium;
using RawaTests.Model.Base;

namespace RawaTests.StepOne
{
    public class DimensionWCModel : BaseWebContainerModel
    {      
        public IWebElement Description { get; set; }
        public IWebElement MinusSign { get; set; }
        public IWebElement PlusSign { get; set; }
        public IWebElement Input { get; set; }

        public override bool IsValid()
        {
            return Description != null && MinusSign != null && PlusSign != null && Input != null;
        }
    }
}
