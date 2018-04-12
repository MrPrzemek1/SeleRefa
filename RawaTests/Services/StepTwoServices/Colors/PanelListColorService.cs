using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.IWebElements.TextElements;
using RawaTests.Models.StepTwo.PanelElement;
using RawaTests.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Models.StepTwo
{
    class PanelListColorService : BaseService
    {
        public PanelElementColorModel GetPanelListForColors()
        {
            var panel = Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.panelList));

            PanelElementColorModel panelElement = new PanelElementColorModel(new NxLabels(panel));
            return panelElement;
        }
    }
}
