using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepOne;
using RawaTests.Model.Room3D;
using RawaTests.Services.Base;

namespace RawaTests.Services
{
    public class Room3DServices : BaseService
    {
        public Room3DServices() : base()
        {

        }

        public Rooms3DWCModel Get3DModel()
        {
            // obrazek przedstawiający wygląd pomieszczenia
            var imageModel = Manager.FindWebElementAndWait(By.ClassName(ImageRoomElementsLocators.Room3DViewClass));
            // atrybuty "letter" w których zawieraja sie wymiary obrazka pomieszczenia
            var imageDimension = imageModel.FindWebElementsAndWait(By.ClassName(ImageRoomElementsLocators.Room3DDimenision));

            Rooms3DWCModel result = new Rooms3DWCModel();

            result.RoomImage = imageModel != null ? imageModel : imageModel = null;

            for (int i = 0; i < imageDimension.Count; i++)
            {
                result.Room3D.Add(new Room3DWCModel
                {
                    Room3dImage = imageDimension[i],
                });
            }           
            return result;
        }
    }
}
