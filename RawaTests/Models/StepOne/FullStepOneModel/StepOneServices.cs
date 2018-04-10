using OpenQA.Selenium.Support.UI;
using RawaTests.Services;
using RawaTests.StepOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RawaTests.Helpers.DriverHelper.DriverHelper;

namespace RawaTests.Model.StepTwo
{
    public static class FacadeBuilder
    {
        public static StepOneFacade GetStepOneFacade()
        {
            Room3DServices c = new Room3DServices();
            ShapeRoomServices b = new ShapeRoomServices();
            DimensionServices a = new DimensionServices();

            StepOneFacade model = new StepOneFacade(a, b, c);

            return model;
        }
    }
}
