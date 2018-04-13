using RawaTests.Lists;
using RawaTests.Model.Room3D;
using RawaTests.Services;
using RawaTests.StepOne;

namespace RawaTests.Model.StepTwo
{
    public class StepOneFacade
    {
        private DimensionWCServices Dimensions { get; set; }
        private ShapeRoomServices Shapes { get; set; }
        private Room3DServices RoomView { get; set; }

        public StepOneFacade(DimensionWCServices pageModel, ShapeRoomServices shapeModel, Room3DServices roomModel)
        {
            Dimensions = pageModel;
            Shapes = shapeModel;
            RoomView = roomModel;
        }

        public ShapesRoomWCModel GetShapes()
        {
            return this.Shapes.GetShapes();
        }
        public DimensionsWCModel GetDimensions()
        {
            return this.Dimensions.GetDimensions();
        }
        public Rooms3DWCModel GetRoom3DModel()
        {
            return this.RoomView.Get3DModel();
        }
    }
}
