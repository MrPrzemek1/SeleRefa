using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Model.Base.Buttons;
using System.Collections.Generic;
using System.Linq;
using static RawaTests.Helpers.DriverHelper.DriverHelp;
namespace RawaTests.StepOne
{
    class DimensionServices
    {
        public DimensionsPageModel GetDimensions()
        {
           var btnPlus = new NxButton(FindElements(By.XPath(ShapeRoomElementsLocators.PlusSignClass)));
           var btnMinus = new NxButton(FindElement(By.XPath(ShapeRoomElementsLocators.MinusSignClass)));
           //var descriptionField = FindElements(By.XPath(ShapeRoomElementsLocators.DescriptionFieldClass));
           //var inputField = FindElements(By.XPath(ShapeRoomElementsLocators.InputFieldClass));

           DimensionsPageModel result = new DimensionsPageModel();

           for(int i=0; i< btnPlus.Count; ++i)
            {
                result.Elements.Add(new DimensionModel
                {
                    PlusSign = btnPlus[i],
                    MinusSign = btnMinus[i],
                    //Input = inputField.Count > i ? inputField[i]  : null,
                    //Name = descriptionField.Count > i ? descriptionField[i].Text : null
                });
            }
            return result;
        }
        /// <summary>
        /// Metoda zwracająca model elementu w którym możemy modyfikować wielkość pomieszczenia
        /// </summary>
        /// <param name="name">etykieta wymiaru np: "A"</param>
        /// <returns></returns>
        //public DimensionModel GetDimensionModelByName(string name)
        //{
        //    var dims = GetDimensions();
        //    return dims.Elements.Where(e => e.Name == name).FirstOrDefault();
        //}
    }
}
