using OpenQA.Selenium;
using RawaTests.IWebElements.TextElements;
using RawaTests.Model;
using RawaTests.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Lists
{
    public class ShapeRoomPageModel
    {
        public NxLabels Header { get; set; }
        public List<ShapeRoomModel> Shapes { get; set; }

        public ShapeRoomPageModel()
        {
            Shapes = new List<ShapeRoomModel>();
        }
        public void ClickShapeById(string id)
        {
             Shapes.Where(e => e.ShapeOfRoom.GetElementAttribute("shape-id") == id).FirstOrDefault().ShapeOfRoom.Click();            
        }
        public string GetAttribute(int i)
        {
            return Shapes[i].ShapeOfRoom.GetAttribute("class");
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
                if (GetAttribute(i).Equals("active"))
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
