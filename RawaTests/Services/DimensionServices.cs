﻿using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.IWebElements.TextElements;
using RawaTests.Model.Base.Buttons;
using RawaTests.WebElements.Input;
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
           var btnMinus = new NxButton(FindElements(By.XPath(ShapeRoomElementsLocators.MinusSignClass)));
           var descriptionField =new NxWebText(FindElements(By.XPath(ShapeRoomElementsLocators.DescriptionFieldClass)));
           var inputField = new NxInput(FindElements(By.XPath(ShapeRoomElementsLocators.InputFieldClass)));

           DimensionsPageModel result = new DimensionsPageModel();

           for(int i=0; i< btnPlus.Count; ++i)
            {
                result.Elements.Add(new DimensionModel
                {
                    PlusSign = new NxButton(btnPlus[i]),
                    MinusSign = new NxButton(btnPlus[i]),
                    Input = new NxInput(inputField[i]),
                    Name = new NxWebText(descriptionField[i])
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
