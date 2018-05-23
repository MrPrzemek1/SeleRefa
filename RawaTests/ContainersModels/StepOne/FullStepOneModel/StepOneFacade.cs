using RawaTests.Lists;
using RawaTests.Services;
using RawaTests.StepOne;

namespace RawaTests.Model.StepTwo
{
    public class StepOneFacade
    {
        private DimensionWCServices _dimensions { get; set; }
        private ShapeRoomWCServices _shapes { get; set; }
        private Room3DWCServices _roomView { get; set; }

        public StepOneFacade(DimensionWCServices pageModel, ShapeRoomWCServices shapeModel, Room3DWCServices roomModel)
        {
            _dimensions = pageModel;
            _shapes = shapeModel;
            _roomView = roomModel;
        }

        public ShapesRoomWCModel GetShapes() => this._shapes.GetShapes();

        public DimensionsWCModel GetDimensions() => this._dimensions.GetDimensions();

        public Room3DWCModel GetRoom3DModel() => this._roomView.Get3DModel();
    }
}
