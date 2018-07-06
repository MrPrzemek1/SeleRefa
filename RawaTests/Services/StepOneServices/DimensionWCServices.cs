using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Services.Base;
using RawaTests.Managers;

namespace RawaTests.StepOne
{
    public class DimensionWCServices : BaseService
    {
        // private DriverManager Manager;
        public DimensionWCServices(DriverManager manager) : base(manager) { }

        public DimensionsWCModel GetDimensions()
        {
            DimensionsWCModel result = new DimensionsWCModel();
            result.Header = _manager.FindWebElement(By.XPath(DimensionElementsLocators.HeaderLocator));
            var elementsList = _manager.FindWebElementsAndWait(By.XPath(DimensionElementsLocators.ListOfDimensionLocator));
            foreach (var element in elementsList)
            {
                var labelWE = element.FindWebElement(By.ClassName(DimensionElementsLocators.DescriptionFieldLocator));
                var btnPlusWE = element.FindWebElement(By.ClassName(DimensionElementsLocators.PlusSignLocator)); 
                var btnMinusWE = element.FindWebElement(By.ClassName(DimensionElementsLocators.MinusSignLocator)); 
                var inputWE = element.FindWebElement(By.ClassName(DimensionElementsLocators.InputFieldLocator));

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
