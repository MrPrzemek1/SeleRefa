using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.HtmlStrings.ElementsLocators.StepOne;
using RawaTests.Lists;
using RawaTests.Managers;
using RawaTests.Model;
using RawaTests.Services.Base;

namespace RawaTests.Services
{
    public class ShapeRoomWCServices : BaseService
    {
        public ShapeRoomWCServices(DriverManager manager) : base(manager) { }

        /// <summary>
        /// Metoda budująca model listy kształtów pomieszczeń.
        /// </summary>
        /// <returns></returns>
        public ShapesRoomWCModel GetShapes()
        {
            var shape_id = Manager.FindWebElementsAndWait(By.XPath(DimensionElementsLocators.ShapeidLocator));
            var header = Manager.FindWebElementAndWait(By.XPath(ShapeElementsLocators.ShapeHeaderLocator));

            ShapesRoomWCModel listOfShapes = new ShapesRoomWCModel(Manager.Driver);
            listOfShapes.Header = header ?? (header = null);

            for (int i = 0; i < shape_id.Count; i++)
            {
                {
                    listOfShapes.Shapes.Add(new ShapeRoomWCModel
                    {
                        shapeOfRoom =shape_id[i],
                    });
                }
            }
            
            return listOfShapes;
        }
    }
}
