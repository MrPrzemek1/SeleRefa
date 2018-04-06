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
    public class DimensionServices
    {
        public DimensionsPageModel GetDimensions()
        {
            var header = new NxLabels(FindElement(By.XPath(DimensionElementsLocators.Header)));
            var btnPlus = new List<IWebElement>(FindElements(By.XPath(DimensionElementsLocators.PlusSignClass)));
            var btnMinus = new List<IWebElement>(FindElements(By.XPath(DimensionElementsLocators.MinusSignClass)));
            var descriptionField = new List<IWebElement>(FindElements(By.XPath(DimensionElementsLocators.DescriptionFieldClass)));
            var inputField = new List<IWebElement>(FindElements(By.XPath(DimensionElementsLocators.InputFieldClass)));

           DimensionsPageModel result = new DimensionsPageModel();
           result.Header = header != null ? header : header = null;
           for (int i=0; i< btnPlus.Count; ++i)
            {
                result.Elements.Add(new DimensionModel
                {                 
                    PlusSign = new NxButton(btnPlus[i]),
                    MinusSign = new NxButton(btnPlus[i]),
                    Description = new NxLabels(descriptionField[i]),
                    Input = new NxInput(inputField[i]),
                    
                });
            }
            return result;
        }
    }
}
