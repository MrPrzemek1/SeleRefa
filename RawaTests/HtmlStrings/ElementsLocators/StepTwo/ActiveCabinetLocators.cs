using OpenQA.Selenium;
using RawaTests.Helpers.DriverHelper;
using RawaTests.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.HtmlStrings.ElementsLocators.StepTwo
{
    public class ActiveCabinetLocators
    {
        public static string panelHeader = "//div[@class='div-form-active-element']//h5";
        //prawy panel
        public static string rightPanelHelper = "div-form-active-element-right";
        public static string bottomLocation = "bottomLocation";
        public static string rotationInput = "rotation";
        public static string rotationDescBtn = "btn-dec";
        public static string rotationIncBtn = "btn-inc";
        // lewy panel
        public static string leftPanelHelper = "div-form-active-element-left";
        public static string cabinetImageThumb = "active-furniture-img";
        public static string cabinetDimensionLabel = "//div[@class='label-size active-furniture']";
        public static string deleteButton = "btn-delete-furniture";
        public static string detailsButton = "btn-details";

    }
}
