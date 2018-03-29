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
    class ShapeRoomList
    {
        public List<ShapeRoomModel> Shapes { get; set; }

        public ShapeRoomList()
        {
            Shapes = new List<ShapeRoomModel>();
        }
    }
}
