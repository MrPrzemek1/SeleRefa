using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepOne;
using RawaTests.Services.Base;

namespace RawaTests.Services
{
    public class Room3DServices : BaseService
    {
        public Room3DServices() : base()
        {

        }

        public Room3DWCModel Get3DModel()
        {
            // obrazek przedstawiający wygląd pomieszczenia
            var imageModel = Manager.FindWebElementAndWait(By.ClassName(ImageRoomElementsLocators.Room3DViewClass));
            // atrybuty "letter" w których zawieraja sie wymiary obrazka pomieszczenia
            var imageDimension = imageModel.FindWebElementsAndWait(By.ClassName(ImageRoomElementsLocators.Room3DDimenision));

            Room3DWCModel result = new Room3DWCModel(imageModel, imageDimension);
      
            return result;
        }
    }
}
