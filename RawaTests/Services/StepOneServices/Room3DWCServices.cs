using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepOne;
using RawaTests.Managers;
using RawaTests.Services.Base;

namespace RawaTests.Services
{
    public class Room3DWCServices : BaseService
    {
        private DriverManager Manager;
        public Room3DWCServices(DriverManager manager) : base(manager)
        {
            Manager = manager;
        }

        public Room3DWCModel Get3DModel()
        {
            // obrazek przedstawiający wygląd pomieszczenia
            var imageModel = Manager.FindWebElementAndWait(By.ClassName(ImageRoomElementsLocatorsLocators.Room3DViewClass));
            // atrybuty "letter" w których zawieraja sie wymiary obrazka pomieszczenia
            var imageDimension = imageModel.FindWebElementsAndWait(Manager.Driver,By.ClassName(ImageRoomElementsLocatorsLocators.Room3DDimenision));

            Room3DWCModel result = new Room3DWCModel(imageModel, imageDimension);
      
            return result;
        }
    }
}
