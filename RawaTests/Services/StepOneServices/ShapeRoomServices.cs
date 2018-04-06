using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.HtmlStrings.ElementsLocators.StepOne;
using RawaTests.IWebElements;
using RawaTests.IWebElements.TextElements;
using RawaTests.Lists;
using RawaTests.Model;
using System.Collections.Generic;
using System.Linq;
using static RawaTests.Helpers.DriverHelper.DriverHelp;

namespace RawaTests.Services
{
    public class ShapeRoomServices
    {
        public ShapeRoomPageModel GetShapes()
        {
            var shape_id = new List<IWebElement>(FindElements(By.XPath(DimensionElementsLocators.Shapeid),5));
            var header = new NxLabels(FindElement(By.XPath(ShapeElementsLocators.ShapeHeader),5));

            ShapeRoomPageModel listOfShapes = new ShapeRoomPageModel();
            listOfShapes.Header = header != null ? header : header = null;

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

        /// <summary>
        /// Metoda wybierająca jeden z kształtów pomieszczeń
        /// </summary>
        /// <param name="id">id pomieszczenia ktore chcemy wybrac</param>
        /// <returns></returns>
        //public ShapeRoomModel GetShapeByID(string id)
        //{
        //    var usedShape = GetShapes();
        //    return usedShape.Shapes.Where(e => e.Id == id).FirstOrDefault();
        //}
        /// <summary>
        /// Metoda zwracająca wybrany atrybut HTML
        /// </summary>
        /// <param name="attributeName">nazwa atrybutu html ktory chcemy pobrac</param>
        /// <param name="room">Aktywny kształt pomieszczenia</param>
        /// <returns></returns>
        //public string GetUsedShapeAttribute(string attributeName,ShapeRoomModel room)
        //{
        //    return room.ShapeOfRoom.GetAttribute(attributeName);
        //}
    }
}
