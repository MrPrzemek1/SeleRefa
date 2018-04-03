using OpenQA.Selenium;
using RawaTests.Model;
using RawaTests.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Lists
{
    class ShapeRoomPageModel
    {
        public List<ShapeRoomModel> Shapes { get; set; }

        public ShapeRoomPageModel()
        {
            Shapes = new List<ShapeRoomModel>();
        }
    }
}
