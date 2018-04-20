using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.HtmlStrings.ElementsLocators.StepOne;
using RawaTests.Lists;
using RawaTests.Model;
using RawaTests.Services.Base;

namespace RawaTests.Services
{
    public class ShapeRoomWCServices : BaseService
    {
        public ShapeRoomWCServices() : base()
        {

        }
        /// <summary>
        /// Metoda budująca model listy kształtów pomieszczeń.
        /// </summary>
        /// <returns></returns>
        public ShapesRoomWCModel GetShapes()
        {
            var shape_id = Manager.FindWebElementsAndWait(By.XPath(DimensionElementsLocators.Shapeid));
            var header = Manager.FindWebElementAndWait(By.XPath(ShapeElementsLocators.ShapeHeader));

            ShapesRoomWCModel listOfShapes = new ShapesRoomWCModel();
            listOfShapes.Header = header ?? (header = null);

            for (int i = 0; i < shape_id.Count; i++)
            {
                {
                    listOfShapes.Shapes.Add(new ShapeRoomWCModel
                    {
                        ShapeOfRoom =shape_id[i],
                    });
                }
            }
            
            return listOfShapes;
        }
    }
}
