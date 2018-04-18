using OpenQA.Selenium;
using RawaTests.Models.Base;
using System.Collections.Generic;

namespace RawaTests.Models.StepTwo.PanelElement
{
    public class PanelListWindowWCModel
    {
        IWebElement ListOfElements { get; set; }
        IList<IWebElement> WindowList { get; set; }

        public PanelListWindowWCModel(IWebElement div, IList<IWebElement> images)
        {
            ListOfElements = div;
            WindowList = images;
        }
    }
}
