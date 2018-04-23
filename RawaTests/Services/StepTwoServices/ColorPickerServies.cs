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
        public ColorPickerWCModel GetFullModel()
        {
            var rows = GetAllRowsWithColors();
            var colors = GetColorsFromSingleRow();
            ColorPickerWCModel model = new ColorPickerWCModel(rows , colors);
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
    }
}
