using OpenQA.Selenium;
using RawaTests.Model.Base;

namespace RawaTests.StepOne
{
    public class DimensionWCModel : BaseWebContainerModel
    {      
        public IWebElement description { get; set; }
        public IWebElement minusSign { get; set; }
        public IWebElement plusSign { get; set; }
        public IWebElement input { get; set; }

        public override bool IsValid() => description != null && minusSign != null && plusSign != null && input != null;
    }
}
