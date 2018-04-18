using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.HtmlStrings.ElementsLocators.StepTwo
{
    public class CabinetsPanelLocator
    {
        public static string filtrPanel = "panel";
        public static string filtrButton = "//*[@role='button']";
        public static string filtrDropdown = "//html//div[@class='container step1']//li";
        public static string collapsdropdown = "collapseFilter";
        public static string collectionGroup = "accordion";
        public static string szafkiSimplyDolne = "47413";
        public static string collectionSub = "//div[@class='panel panel-default']";
        public static string collectionSubGroup = "//div[@aria-expanded]";
        public static string cabinetImages = "//div[@object-type='furniture']";
    }
}
