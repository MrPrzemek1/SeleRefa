using RawaTests.Lists;
using RawaTests.Model.Room3D;
using RawaTests.Services;
using RawaTests.StepOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Model.StepTwo
{
    public class StepOneModel
    {
        public DimensionServices Dimensions { get; set; }
        public ShapeRoomServices Shapes { get; set; }
        public Room3DServices RoomView { get; set; }

        public StepOneModel(DimensionServices pageModel, ShapeRoomServices shapeModel, Room3DServices roomModel)
        {
            Dimensions = pageModel;
            Shapes = shapeModel;
            RoomView = roomModel;
        }
    }
}
