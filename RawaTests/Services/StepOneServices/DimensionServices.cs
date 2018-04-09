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
            DimensionsPageModel result = new DimensionsPageModel();

            var elementsList = FindWebElements(By.XPath(DimensionElementsLocators.ListOfDimension));
            foreach (var element in elementsList)
            {
                var labelWE = element.FindWebElement(By.ClassName(DimensionElementsLocators.DescriptionFieldClass));
                var btnPlusWE = element.FindWebElement(By.ClassName(DimensionElementsLocators.PlusSignClass));
                var btnMinusWE = element.FindWebElement(By.ClassName(DimensionElementsLocators.MinusSignClass));
                var inputWE = element.FindWebElement(By.ClassName(DimensionElementsLocators.InputFieldClass));
                if (labelWE.GetAttribute("class").Equals(DimensionElementsLocators.DescriptionFieldClass))
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
            return result;

        }
    }
}
