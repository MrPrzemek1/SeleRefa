namespace RawaTests.HtmlStrings.ElementsLocators.StepTwo
{
    public class ActiveWindowFormLocators
    {
        public static string formHeaderLocator = "//div[@class='div-form-active-element']//h5";
        //prawa strona formularza
        public static string bottomLocationHeaderLocator = "//div[@class='div-form-active-element-right']//label";
        public static string bottomLocationInputLocator = "//input[@name='bottomLocation']";
        //lewa strona formularza
        public static string windowImageThumbLocator = "//div[@class='active-element-img']";
        public static string windowDimensionLocator = "//html//div[@class='container step2']//label[2]";
        public static string deleteWindowButtonLocator = "btn-delete";
    }
}
