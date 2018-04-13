using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.HtmlStrings.ElementsLocators.StepTwo
{
    public class StepTwoLocators
    {
        public static string groupOption = "//input[@name='module']";
        public static string panelList = "//div[@class='panel-elements panel-element-list']";
        public static string doorPanelList = "//ul[@class='panel-elements-list door-list']";
        public static string doorsImages = "//*[@object-type='door']";
        public static string doorsProducent = "door-producent";
        public static string windowsImages = "//*[@object-type='window']";
    }
}
