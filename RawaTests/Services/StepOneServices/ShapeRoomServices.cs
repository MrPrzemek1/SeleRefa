using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.HtmlStrings.ElementsLocators.StepOne;
using RawaTests.IWebElements;
using RawaTests.IWebElements.TextElements;
using RawaTests.Lists;
using RawaTests.Model;
using RawaTests.Services.Base;
using System.Collections.Generic;

namespace RawaTests.Services
{
    public class ShapeRoomServices : BaseService
    {
        public ShapeRoomServices() : base()
        {

        }
        public ShapeRoomPageModel GetShapes()
        {
            var shape_id = Manager.FindWebElementsAndWait(By.XPath(DimensionElementsLocators.Shapeid));
            var header = new NxLabels(Manager.FindWebElementWithoutWait(By.XPath(ShapeElementsLocators.ShapeHeader)));

            ShapeRoomPageModel listOfShapes = new ShapeRoomPageModel();
            listOfShapes.Header = header ?? (header = null);

            for (int i = 0; i < shape_id.Count; i++)
            {
                {
                    listOfShapes.Shapes.Add(new ShapeRoomModel
                    {
                        ShapeOfRoom = new NxImage(shape_id[i]),
                    });
                }
            }
            
            return listOfShapes;
        }
    }
}
