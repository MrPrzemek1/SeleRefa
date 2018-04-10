using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.HtmlStrings.ElementsLocators.StepOne;
using RawaTests.IWebElements;
using RawaTests.IWebElements.TextElements;
using RawaTests.Model.Room3D;
using RawaTests.Services.Base;
using System;
using System.Collections.Generic;
using static RawaTests.Helpers.DriverHelper.DriverHelper;

namespace RawaTests.Services
{
   public class Room3DServices : BaseService
    {
        public Room3DServices() : base()
        {

        }
        public Room3DViewPageModel Get3DModel()
        {
            var model = new NxImage(Manager.FindWebElementAndWait(By.ClassName(ImageRoomElementsLocators.Room3DViewClass)));
            //var dim = new List<IWebElement>(Manager.FindWebElementsAndWait(model, By.ClassName(ImageRoomElementsLocators.Room3DDimenision)));
            var dim = model.FindElementsAndWait<NxLabels>(By.ClassName(ImageRoomElementsLocators.Room3DDimenision));

            IWebElement dimE = model.FindElementAndWait(By.ClassName(ImageRoomElementsLocators.Room3DDimenision));
            NxLabels eeee = new NxLabels(dimE);


            Room3DViewPageModel result = new Room3DViewPageModel();

            result.RoomImage = model != null ? model : model = null;
            for (int i = 0; i < dim.Count; i++)
            {
                result.Room3D.Add(new Room3DViewModel
                {
                    Room3DDimension = dim[i],
                });
            }           
            return result;
        }
    }
}
