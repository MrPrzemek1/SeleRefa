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
            result.Header = Manager.FindWebElement(By.XPath(DimensionElementsLocators.Header));
            var elementsList = Manager.FindWebElementsAndWait(By.XPath(DimensionElementsLocators.ListOfDimension));
            foreach (var element in elementsList)
            {
                var labelWE = element.FindWebElement(By.ClassName(DimensionElementsLocators.DescriptionFieldClass));
                var btnPlusWE = element.FindWebElement(By.ClassName(DimensionElementsLocators.PlusSignClass)); 
                var btnMinusWE = element.FindWebElement(By.ClassName(DimensionElementsLocators.MinusSignClass)); 
                var inputWE = element.FindWebElement(By.ClassName(DimensionElementsLocators.InputFieldClass));

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
