using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Managers;
using RawaTests.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.Lists
{
    public class ShapesRoomWCModel
    {
        public IWebElement Header { get; set; }
        public List<ShapeRoomWCModel> Shapes { get; set; }
        private DriverManager Manager;
        public ShapesRoomWCModel()
        {
            Shapes = new List<ShapeRoomWCModel>();
        }
        /// <summary>
        /// Metoda klikająca w kształt pomieszczenia
        /// </summary>
        /// <param name="id">id pomieszczenia</param>
        public void ClickShapeById(string id)
        {
             Shapes.Where(e => e.ShapeOfRoom.GetAttribute(HtmlAttributesConsts.SHAPE_ID) == id).FirstOrDefault().ShapeOfRoom.ClickIfElementIsClickable(Manager.Driver);            
        }
        /// <summary>
        /// Metoda zwracająca atrybut "class"
        /// </summary>
        /// <param name="i">id pomieszczenia</param>
        /// <returns></returns>
        public string GetAttribute(int i)
        {
            return Shapes[i].ShapeOfRoom.GetAttribute(HtmlAttributesConsts.CLASS);
        }
        /// <summary>
        /// Metoda sprawdzająca czy po kilknięciu w miniaturke pomieszczenia jej klasa zmienia się na active
        /// </summary>
        /// <returns>Zwraca true jezeli dla wszystkich elementow klasa zmieniła się na odpowiednią</returns>
        public bool ClickingOnTheShapes()
        {
            string[] shapesArray = new String[] { "23", "25", "26", "27", "28", "30" };
            List<bool> ClassChanged = new List<bool>();
            for (int i = 0; i < shapesArray.Length; i++)
            {
                ClickShapeById(shapesArray[i]);
                if (GetAttribute(i).Equals(HtmlAttributesConsts.ACTIVE))
                {
                    ClassChanged.Add(true);
                }
                else
                    ClassChanged.Add(false);
            }
            if (ClassChanged.All(e=>e==true))
            {
                return true;
            }
            return false;            
        }
    }
}
