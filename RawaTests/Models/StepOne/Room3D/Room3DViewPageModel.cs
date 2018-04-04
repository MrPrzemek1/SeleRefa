using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RawaTests.HtmlStrings.ElementsLocators.StepOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RawaTests.Helpers.DriverHelper.DriverHelp;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests.Model.Room3D
{
    public class Room3DViewPageModel : Room3DViewModel
    {
        public IList<Room3DViewModel> Room3D { get; set; }
        public Room3DViewPageModel()
        {
            Room3D = new List<Room3DViewModel>();
        }

        public string[] GetRoomDimension()
        {
            return Room3D.Select(e => e.Room3DDimension.GetAttribute("style")).ToArray();
        }

        public void Wait(int seconds)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(ImageRoomElementsLocators.Room3DViewClass)));
        }
    }
}
