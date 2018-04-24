using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo;
using RawaTests.ContainersModels.StepTwo.ColorPicker;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Services.StepTwoServices
{
    public class ColorPickerServies: BaseService
    {
        #region LeftPanelOfColorPicker      
        public ColorPickerWCModel GetFullColorPickerModel()
        {
            AllRowsWithColorsWCModel rows = GetAllRowsWithColors();
            AllColorsInSingleRowWCModel colors = GetColorsFromSingleRow();
            RightPanelColorPickerWCModel rightPanel = GetRightPanelColorPickerModel();
            ColorPickerWCModel model = new ColorPickerWCModel(rows , colors, rightPanel);
            return model;
        }
        private SingleRowWithColorsWCModel GetSingleRowsWithColors()
        {
            IWebElement rows = Manager.FindWebElement(By.XPath(ColorPickerLocators.singleRow));
            SingleRowWithColorsWCModel singleRowColorsWCModel = new SingleRowWithColorsWCModel(rows);

            return singleRowColorsWCModel;
        }
        private AllRowsWithColorsWCModel GetAllRowsWithColors()
        {
            AllRowsWithColorsWCModel result = new AllRowsWithColorsWCModel();
            IList<IWebElement> allRows = Manager.FindWebElements(By.XPath(ColorPickerLocators.singleRow));
            foreach (var item in allRows)
            {
                result.allRows.Add(new SingleRowWithColorsWCModel(item));
            }
            return result;
        }

        private SingleColorWCModel GetSingleColor()
        {
            var row = GetSingleRowsWithColors();
            IWebElement singleColor = row.RowColors.FindWebElement(By.ClassName(ColorPickerLocators.singleColor));

            SingleColorWCModel singleColorModel = new SingleColorWCModel(singleColor);
            return singleColorModel;
        }
        private AllColorsInSingleRowWCModel GetColorsFromSingleRow()
        {
            AllColorsInSingleRowWCModel allColorsInSingleRow = new AllColorsInSingleRowWCModel();
            var singleRow = GetSingleRowsWithColors();
            var colors = Manager.FindWebElements(By.ClassName(ColorPickerLocators.singleColor));
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
            IWebElement colorSquare = Manager.FindWebElement(By.ClassName(ColorPickerLocators.colorSquare));
            IWebElement submintButton = Manager.FindWebElement(By.ClassName(ColorPickerLocators.submitButton));
            IWebElement cancelButton = Manager.FindWebElement(By.ClassName(ColorPickerLocators.cancelButton));
            ColorSliderWCModel slider = GetPickerSliderModel();
            RightPanelColorPickerWCModel rightPanelModel = new RightPanelColorPickerWCModel(colorSquare,cancelButton,submintButton,slider);
            return rightPanelModel;
        }
        private ColorSliderWCModel GetPickerSliderModel()
        {
            IWebElement colorColumn = Manager.FindWebElement(By.ClassName(ColorPickerLocators.colorColumn));
            IWebElement colorSlider = colorColumn.FindWebElement(By.ClassName(ColorPickerLocators.colorSlider));
            ColorSliderWCModel sliderModel = new ColorSliderWCModel(colorColumn, colorSlider);
            return sliderModel;
        }
        #endregion
    }
}
