using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Services.Base;
using RawaTests;
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
            result.Header = Manager.FindWebElement(By.XPath(DimensionElementsLocators.Header));
            var elementsList = Manager.FindWebElementsAndWait(By.XPath(DimensionElementsLocators.ListOfDimension));
            foreach (var element in elementsList)
            {
                var labelWE = element.FindWebElementAndWait(By.ClassName(DimensionElementsLocators.DescriptionFieldClass));
                var btnPlusWE = element.FindWebElementAndWait(By.ClassName(DimensionElementsLocators.PlusSignClass)); 
                var btnMinusWE = element.FindWebElementAndWait(By.ClassName(DimensionElementsLocators.MinusSignClass)); 
                var inputWE = element.FindWebElementAndWait(By.ClassName(DimensionElementsLocators.InputFieldClass));

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
