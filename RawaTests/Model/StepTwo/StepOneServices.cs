using RawaTests.Services;
using RawaTests.StepOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Model.StepTwo
{
    public class StepOneServices
    {
        public StepOneModel GetFullModel()
        {
            Room3DServices c = new Room3DServices();
            ShapeRoomServices b = new ShapeRoomServices();
            DimensionServices a = new DimensionServices();

            StepOneModel model = new StepOneModel(a,b,c);

            return model;
        }


    }
}
