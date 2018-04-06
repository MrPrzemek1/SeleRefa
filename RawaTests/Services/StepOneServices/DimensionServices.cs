using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.IWebElements.TextElements;
using RawaTests.Model.Base.Buttons;
using RawaTests.WebElements.Input;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static RawaTests.Helpers.DriverHelper.DriverHelp;
namespace RawaTests.StepOne
{
    public class DimensionServices
    {
        public DimensionsPageModel GetDimensions()
        {
            /*var header = new NxLabels(FindElement(By.XPath(DimensionElementsLocators.Header)));
            var btnPlus = new List<IWebElement>(FindElements(By.XPath(DimensionElementsLocators.PlusSignClass)));
            var btnMinus = new List<IWebElement>(FindElements(By.XPath(DimensionElementsLocators.MinusSignClass)));
            var descriptionField = new List<IWebElement>(FindElements(By.XPath(DimensionElementsLocators.DescriptionFieldClass)));
            var inputField = new List<IWebElement>(FindElements(By.XPath(DimensionElementsLocators.InputFieldClass)));

           DimensionsPageModel result = new DimensionsPageModel();
           result.Header = header ?? (header = null);
            
                for (int i = 0; i < descriptionField.Count; i++)
                {
                    result.Elements.Add(new DimensionModel
                    {
                        Description = new NxLabels(descriptionField[i]),
                        PlusSign = new NxButton(btnPlus[i]),
                        MinusSign = new NxButton(btnMinus[i]),
                        Input = new NxInput(inputField[i]),
                    });
                }
                    
            return result;
            */
            DimensionsPageModel result = new DimensionsPageModel();

            var elementsList = Driver.FindElements(By.XPath("//html//div[@class='roomForm-container']//li"));
            foreach (var element in elementsList)
            {
                var labelWE = element.FindElement(By.XPath("//label[@class='set-room-params-letters']"));
                var btnPlusWE = element.FindElement(By.XPath("//button[@class='set-room-params-letters']"));
                var btnMinusWE = element.FindElement(By.XPath("//button[@class='set-room-params-letters']"));
                var inputWE = element.FindElement(By.XPath("//input[@class='set-room-params-letters']"));
                if (!string.IsNullOrEmpty(labelWE.Text))
                {
                    result.Elements.Add(new DimensionModel
                    {
                        Description = new NxLabels(labelWE),
                        PlusSign = new NxButton(btnPlusWE),
                        MinusSign = new NxButton(btnMinusWE),
                        Input = new NxInput(inputWE),
                    });
                }
            }

        }
    }
}
