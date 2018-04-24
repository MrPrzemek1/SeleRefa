using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.HtmlStrings.ElementsLocators.StepTwo
{
    public class CabinetsPanelLocators
    {
        //filtry
        public static string filterButton = "//a[@role='button'][contains(text(),'Filtrowanie')]";
        public static string filterBodyColor= "//html//div[@class='container step2']//li[1]";
        public static string filterFrontType = "//html//div[@class='container step2']//li[2]";

        //Eco dolne
        public static string ecoBottomId = "47574";
        public static string bottomCabintesEco = "//a[@href='#47574']";
        public static string bottomOpenCabinetsEco = "//input[@collection-sub-group-id='47575']";
        public static string bottomClosedCabinetsEco = "//input[@collection-sub-group-id='47576']";
        public static string bottomImagesOfCabinetsEco = "//div[@object-type='furniture']";
        // Eco górne
        public static string ecoUpperId = "47577";
        public static string upperCabinetsEco = "//a[@href='#47577']";
        public static string upperOpenCabinetsEco = "//html//div[@id='47577']//label[1]/input[1]";
        public static string upperClosedCabinetsEco = "//html//div[@id='47577']//label[2]/input[1]";
        public static string upperImagesOfCabinetsEco = "//div[@object-type='furniture']";
        //simply dolne       
        public static string simplyBottomId = "47413";
        public static string bottomCabintesSimply = "//a[@href='#47413']";
        public static string bottomOpenCabinetsSimply = "//html//div[@id='47413']//label[1]/input[1]";
        public static string bottomClosedCabinetsSimply = "//html//div[@id='47413']//label[2]/input[1]";
        public static string bottomImagesOfCabinetsSimply = "//div[@object-type='furniture']";
        //Simply górne
        public static string simplyUpperId = "47414";
        public static string upperCabintesSimply = "//a[@href='#47414']";
        public static string upperOpenCabinetsSimply = "//html//div[@id='47414']//label[1]/input[1]";
        public static string upperClosedCabinetsSimply = "//html//div[@id='47414']//label[2]/input[1]";
        public static string upperImagesOfCabinetsSimply = "//div[@object-type='furniture']";

        public static string canvas = "//div[@class='scene3d']";
    }
}
