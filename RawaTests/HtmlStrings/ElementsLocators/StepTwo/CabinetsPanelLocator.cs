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
        public static string collectionGroup = "//html//div[@id='accordion']/div";
        public static string SzafkiSimplyDolne = "47413";
        public static string SzafkiSimplyDolneGrupy = "//html//div[@id='47413']//label";
        public static string collectionSubGroup = "//html//div[@class='container step1']//label/input";
        public static string cabinetImages = "//div[@object-type='furniture']";
    }
}
