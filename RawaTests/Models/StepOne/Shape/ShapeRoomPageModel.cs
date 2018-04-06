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
    }
}
