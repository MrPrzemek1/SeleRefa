using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.HtmlStrings.ElementsLocators.StepTwo
{
    public class ColorPickerLocators
    {
        public static string singleColor = "sp-thumb-inner";
        public static string singleRow = "//div[contains(@class,'sp-cf sp-palette-row sp-palette-row')]";
        public static string colorColumn = "sp-hue";
        public static string colorSlider = "sp-slider";
        public static string colorSquare = "sp-val";
        public static string submitButton = "sp-choose";
        public static string cancelButton = "sp-cancel";
    }
}
