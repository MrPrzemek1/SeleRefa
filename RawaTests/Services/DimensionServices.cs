using OpenQA.Selenium;
using RawaTests.Helpers;
using System.Linq;
using static TestyRawa.DriverHelper.Browser;
namespace RawaTests.StepOne
{
    class DimensionServices
    {
        public DimensionsList GetDimensions()
        {
           var btnPlus =  Driver.FindElements(By.XPath(HtmlStepOneElements.PlusSignClass));
           var btnMinus = Driver.FindElements(By.XPath(HtmlStepOneElements.MinusSignClass));
           var descriptionField = Driver.FindElements(By.XPath(HtmlStepOneElements.DescriptionFieldClass));
           var inputField = Driver.FindElements(By.XPath(HtmlStepOneElements.InputFieldClass));

            DimensionsList result = new DimensionsList();

            for(int i=0; i< btnPlus.Count; ++i)
            {
                result.Elements.Add(new DimensionModel
                {
                    PlusSign = btnPlus[i],
                    MinusSign = btnMinus[i],
                    Input = inputField.Count > i ? inputField[i]  : null,
                    Name = descriptionField.Count > i ? descriptionField[i].Text : null
                });
            }
            return result;
        }
        /// <summary>
        /// Metoda zwracająca model elementu w którym możemy modyfikować wielkość pomieszczenia
        /// </summary>
        /// <param name="name">etykieta wymiaru np: "A"</param>
        /// <returns></returns>
        public DimensionModel GetDimensionModelByName(string name)
        {
            var dims = GetDimensions();
            return dims.Elements.Where(e => e.Name == name).FirstOrDefault();
        }
    }
}
