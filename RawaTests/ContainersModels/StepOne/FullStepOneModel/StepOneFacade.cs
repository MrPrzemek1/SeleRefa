using RawaTests.Lists;
using RawaTests.Services;
using RawaTests.StepOne;

namespace RawaTests.Model.StepTwo
{
    public class StepOneFacade
    {
        private DimensionWCServices Dimensions { get; set; }
        private ShapeRoomWCServices Shapes { get; set; }
        private Room3DWCServices RoomView { get; set; }

        public StepOneFacade(DimensionWCServices pageModel, ShapeRoomWCServices shapeModel, Room3DWCServices roomModel)
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
        public Room3DWCModel GetRoom3DModel()
        {
            return this.RoomView.Get3DModel();
        }
    }
}
