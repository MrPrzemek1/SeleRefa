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
        public static string filtrDropdown = "//html//div[@class='furnitureFilter']//li";
        public static string collapsdropdown = "collapseFilter";
        public static string collectionGroup = "accordion";
        public static string collectionSubGroup = "collectionSubGroup";
        public static string cabinetImages = "//div[@object-type='furniture']";
    }
}
