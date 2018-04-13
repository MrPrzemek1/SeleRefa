using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepOne;
using RawaTests.Model.Room3D;
using RawaTests.Services.Base;
using RawaTests.WebElementsModels;

namespace RawaTests.Services
{
    public class Room3DServices : BaseService
    {
        public Room3DServices() : base()
        {

        }
        public Rooms3DWCModel Get3DModel()
        {
            var model = new NxWEImageModel(Manager.FindWebElementAndWait(By.ClassName(ImageRoomElementsLocators.Room3DViewClass)));
            var dim = model.FindElementsAndWait<NxWEImageModel>(By.ClassName(ImageRoomElementsLocators.Room3DDimenision));

            Rooms3DWCModel result = new Rooms3DWCModel();

            result.RoomImage = model != null ? model : model = null;

            for (int i = 0; i < dim.Count; i++)
            {
                result.Room3D.Add(new Room3DWCModel
                {
                    Room3dImage = dim[i],
                });
            }           
            return result;
        }
    }
}
