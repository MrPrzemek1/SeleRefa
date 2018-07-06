using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo;
using RawaTests.ContainersModels.StepTwo.ColorPicker;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Managers;
using RawaTests.Services.Base;
using System.Collections.Generic;

namespace RawaTests.Services.StepTwoServices
{
    public class ColorPickerServies: BaseService
    {
        public ColorPickerServies(DriverManager manager) : base(manager) { }

        #region LeftPanelOfColorPicker      
        public ColorPickerWCModel GetFullColorPickerModel()
        {
            AllRowsWithColorsWCModel rows = GetAllRowsWithColors();
            allColorsInSingleRowWCModel colors = GetColorsFromSingleRow();
            RightPanelColorPickerWCModel rightPanel = GetRightPanelColorPickerModel();
            ColorPickerWCModel model = new ColorPickerWCModel(rows , colors, rightPanel);
            return model;
        }
        private SingleRowWithColorsWCModel GetSingleRowsWithColors()
        {
            IWebElement rows = _manager.FindWebElement(By.XPath(ColorPickerLocators.singleRowLocator));
            SingleRowWithColorsWCModel singleRowColorsWCModel = new SingleRowWithColorsWCModel(rows);

            return singleRowColorsWCModel;
        }
        private AllRowsWithColorsWCModel GetAllRowsWithColors()
        {
            AllRowsWithColorsWCModel result = new AllRowsWithColorsWCModel();
            IList<IWebElement> allRows = _manager.FindWebElements(By.XPath(ColorPickerLocators.singleRowLocator));
            foreach (var item in allRows)
            {
                result.allRows.Add(new SingleRowWithColorsWCModel(item));
            }
            return result;
        }

        private SingleColorWCModel GetSingleColor()
        {
            var row = GetSingleRowsWithColors();
            IWebElement singleColor = row.RowColors.FindWebElement(By.ClassName(ColorPickerLocators.singleColorLocator));

            SingleColorWCModel singleColorModel = new SingleColorWCModel(singleColor);
            return singleColorModel;
        }
        private allColorsInSingleRowWCModel GetColorsFromSingleRow()
        {
            allColorsInSingleRowWCModel allColorsInSingleRow = new allColorsInSingleRowWCModel(_manager.Driver);
            var singleRow = GetSingleRowsWithColors();
            var colors = _manager.FindWebElements(By.ClassName(ColorPickerLocators.singleColorLocator));
            foreach (var singleColor in colors)
            {
                allColorsInSingleRow.allColorsInSingleRow.Add(new SingleColorWCModel(singleColor));
            }
            return allColorsInSingleRow;
        }
        #endregion
        #region RightPanelOfColorPicker
        private RightPanelColorPickerWCModel GetRightPanelColorPickerModel()
        {
            IWebElement colorSquare = _manager.FindWebElement(By.ClassName(ColorPickerLocators.colorSquareLocator));
            IWebElement submintButton = _manager.FindWebElement(By.ClassName(ColorPickerLocators.submitButtonLocator));
            IWebElement cancelButton = _manager.FindWebElement(By.ClassName(ColorPickerLocators.cancelButtonLocator));
            ColorSliderWCModel slider = GetPickerSliderModel();
            RightPanelColorPickerWCModel rightPanelModel = new RightPanelColorPickerWCModel(_manager.Driver,colorSquare,cancelButton,submintButton,slider);
            return rightPanelModel;
        }
        private ColorSliderWCModel GetPickerSliderModel()
        {
            IWebElement colorColumn = _manager.FindWebElement(By.ClassName(ColorPickerLocators.colorColumnLocator));
            IWebElement colorSlider = colorColumn.FindWebElement(By.ClassName(ColorPickerLocators.colorSliderLocator));
            ColorSliderWCModel sliderModel = new ColorSliderWCModel(_manager.Driver, colorColumn, colorSlider);
            return sliderModel;
        }
        #endregion
    }
}
