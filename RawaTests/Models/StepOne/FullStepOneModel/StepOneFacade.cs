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
    public class StepOneFacade
    {
        private DimensionServices Dimensions { get; set; }
        private ShapeRoomServices Shapes { get; set; }
        private Room3DServices RoomView { get; set; }

        public StepOneFacade(DimensionServices pageModel, ShapeRoomServices shapeModel, Room3DServices roomModel)
        {
            Dimensions = pageModel;
            Shapes = shapeModel;
            RoomView = roomModel;
        }

        public ShapeRoomPageModel GetShapes()
        {
            return this.Shapes.GetShapes();
        }
        public DimensionsPageModel GetDimensions()
        {
            return this.Dimensions.GetDimensions();
        }
        public Room3DViewPageModel GetRoomDimension()
        {
            return this.RoomView.Get3DModel();
        }
    }
}
