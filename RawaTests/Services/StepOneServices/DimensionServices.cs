using OpenQA.Selenium;
using RawaTests.Extensions;
using RawaTests.Helpers;
using RawaTests.Helpers.DriverHelper;
using RawaTests.IWebElements.TextElements;
using RawaTests.Model.Base.Buttons;
using RawaTests.Services.Base;
using RawaTests.WebElements.Input;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace RawaTests.StepOne
{
    public class DimensionServices : BaseService
    {
        public DimensionServices() : base()
        {

        }
        public DimensionsPageModel GetDimensions()
        {         
            DimensionsPageModel result = new DimensionsPageModel();

            var elementsList = Manager.FindWebElementsAndWait(By.XPath(DimensionElementsLocators.ListOfDimension));
            foreach (var element in elementsList)
            {
                var labelWE = element.FindElementWithoutWait(By.ClassName(DimensionElementsLocators.DescriptionFieldClass));
                var btnPlusWE = element.FindElementWithoutWait(By.ClassName(DimensionElementsLocators.PlusSignClass));
                var btnMinusWE = element.FindElementWithoutWait(By.ClassName(DimensionElementsLocators.MinusSignClass));
                var inputWE = element.FindElementWithoutWait(By.ClassName(DimensionElementsLocators.InputFieldClass));

                if (labelWE != null)
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
