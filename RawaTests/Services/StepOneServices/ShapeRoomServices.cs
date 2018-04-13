using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.HtmlStrings.ElementsLocators.StepOne;
using RawaTests.Lists;
using RawaTests.Model;
using RawaTests.Services.Base;
using RawaTests.WebElementsModels;

namespace RawaTests.Services
{
    public class ShapeRoomServices : BaseService
    {
        public ShapeRoomServices() : base()
        {

        }
        /// <summary>
        /// Metoda budująca model listy kształtów pomieszczeń.
        /// </summary>
        /// <returns></returns>
        public ShapesRoomWCModel GetShapes()
        {
            var shape_id = Manager.FindWebElementsAndWait(By.XPath(DimensionElementsLocators.Shapeid));
            var header = new NxWELabelModel(Manager.FindWebElementWithoutWait(By.XPath(ShapeElementsLocators.ShapeHeader)));

            ShapesRoomWCModel listOfShapes = new ShapesRoomWCModel();
            listOfShapes.Header = header ?? (header = null);

            for (int i = 0; i < shape_id.Count; i++)
            {
                {
                    listOfShapes.Shapes.Add(new ShapeRoomWCModel
                    {
                        ShapeOfRoom = new NxWEImageModel(shape_id[i]),
                    });
                }
            }
            
            return listOfShapes;
        }
    }
}
