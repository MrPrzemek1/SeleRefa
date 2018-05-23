namespace RawaTests.HtmlStrings.ElementsLocators.StepTwo
{
    public class CabinetsPanelLocators
    {
        //filtry
        public static string filterButtonLocator = "//a[@role='button'][contains(text(),'Filtrowanie')]";
        public static string filterBodyColorLocator = "//html//div[@class='container step2']//li[1]";
        public static string filterFrontTypeLocator = "//html//div[@class='container step2']//li[2]";
        //Eco dolne
        public static string ecoBottomIdLocator = "47574";
        public static string bottomCabintesEcoLocator = "//a[@href='#47574']";
        public static string bottomOpenCabinetsEcoLocator = "//input[@collection-sub-group-id='47575']";
        public static string bottomClosedCabinetsEcoLocator = "//input[@collection-sub-group-id='47576']";
        public static string bottomImagesOfCabinetsEcoLocator = "//div[@object-type='furniture']";
        // Eco górne
        public static string ecoUpperIdLocator = "47577";
        public static string upperCabinetsEcoLocator = "//a[@href='#47577']";
        public static string upperOpenCabinetsEcoLocator = "//html//div[@id='47577']//label[1]/input[1]";
        public static string upperClosedCabinetsEcoLocator = "//html//div[@id='47577']//label[2]/input[1]";
        public static string upperImagesOfCabinetsEcoLocator = "//div[@object-type='furniture']";
        //simply dolne       
        public static string simplyBottomIdLocator = "47413";
        public static string bottomCabintesSimplyLocator = "//a[@href='#47413']";
        public static string bottomOpenCabinetsSimplyLocator = "//html//div[@id='47413']//label[1]/input[1]";
        public static string bottomClosedCabinetsSimplyLocator = "//html//div[@id='47413']//label[2]/input[1]";
        public static string bottomImagesOfCabinetsSimplyLocator = "//div[@object-type='furniture']";
        //Simply górne
        public static string simplyUpperIdLocator = "47414";
        public static string upperCabintesSimplyLocator = "//a[@href='#47414']";
        public static string upperOpenCabinetsSimplyLocator = "//html//div[@id='47414']//label[1]/input[1]";
        public static string upperClosedCabinetsSimplyLocator = "//html//div[@id='47414']//label[2]/input[1]";
        public static string upperImagesOfCabinetsSimplyLocator = "//div[@object-type='furniture']";

        public static string canvasLocator = "//div[@class='scene3d']";
    }
}
