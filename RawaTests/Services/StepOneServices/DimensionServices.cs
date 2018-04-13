using OpenQA.Selenium;
using RawaTests.Extensions;
using RawaTests.Helpers;
using RawaTests.Services.Base;
using RawaTests.WebElementsModels;
namespace RawaTests.StepOne
{
    public class DimensionWCServices : BaseService
    {
        public DimensionWCServices() : base()
        {

        }
        public DimensionsWCModel GetDimensions()
        {         
            DimensionsWCModel result = new DimensionsWCModel();
            result.Header = new NxWELabelModel(Manager.FindWebElementWithoutWait(By.XPath(DimensionElementsLocators.Header)));
            var elementsList = Manager.FindWebElementsAndWait(By.XPath(DimensionElementsLocators.ListOfDimension));
            foreach (var element in elementsList)
            {
                var labelWE = new NxWELabelModel(Manager.FindWebElementAndWait(element, By.ClassName(DimensionElementsLocators.DescriptionFieldClass)));
                var btnPlusWE = new NxWEButtonModel(Manager.FindWebElementWithoutWait(element, By.ClassName(DimensionElementsLocators.PlusSignClass)));
                var btnMinusWE = new NxWEButtonModel(Manager.FindWebElementWithoutWait(element, By.ClassName(DimensionElementsLocators.MinusSignClass)));
                var inputWE = new NxWEInputModel(Manager.FindWebElementWithoutWait(element, By.ClassName(DimensionElementsLocators.InputFieldClass)));
               
                    result.DimensionElements.Add(new DimensionWCModel
                    {
                        Description = labelWE,
                        PlusSign = btnPlusWE,
                        MinusSign = btnMinusWE,
                        Input = inputWE,
                    });                        
            }
            return result;

        }
    }
}
