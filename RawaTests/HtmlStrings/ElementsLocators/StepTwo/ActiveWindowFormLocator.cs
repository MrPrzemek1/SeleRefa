using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.HtmlStrings.ElementsLocators.StepTwo
{
    public class ActiveWindowFormLocator
    {
        public static string formHeader = "//div[@class='div-form-active-element']//h5";
        //prawa strona formularza
        public static string bottomLocationHeader = "//div[@class='div-form-active-element-right']//label";
        public static string bottomLocationInput = "//input[@name='bottomLocation']";
        //lewa strona formularza
        public static string windowImageThumb = "//div[@class='active-element-img']";
        public static string windowDimension = "//html//div[@class='container step2']//label[2]";
        public static string deleteWindowButton = "btn-delete";
    }
}
