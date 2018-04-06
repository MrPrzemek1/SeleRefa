using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.HtmlStrings.ElementsLocators.StepOne;
using RawaTests.IWebElements;
using RawaTests.IWebElements.TextElements;
using RawaTests.Model.Room3D;
using System;
using System.Collections.Generic;
using static RawaTests.Helpers.DriverHelper.DriverHelp;

namespace RawaTests.Services
{
   public class Room3DServices
    {
        public Room3DViewPageModel Get3DModel()
        {
            var model = new NxImage(FindElement(By.ClassName(ImageRoomElementsLocators.Room3DViewClass)));
            var dim = new List<IWebElement>(FindElements(By.ClassName(ImageRoomElementsLocators.Room3DDimenision)));

            Room3DViewPageModel result = new Room3DViewPageModel();
            result.RoomImage = model != null ? model : model = null;
            for (int i = 0; i < dim.Count; i++)
            {
                result.Room3D.Add(new Room3DViewModel
                {
                    Room3DDimension = new NxLabels(dim[i]),
                });
            }           
            return result;
        }
    }
}
