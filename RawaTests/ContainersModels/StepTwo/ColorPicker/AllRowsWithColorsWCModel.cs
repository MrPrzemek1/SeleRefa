using System.Collections.Generic;

namespace RawaTests.ContainersModels.StepTwo.ColorPicker
{
    public class AllRowsWithColorsWCModel
    {
        public IList<SingleRowWithColorsWCModel> allRows { get; set; }
        public AllRowsWithColorsWCModel()
        {
            allRows = new List<SingleRowWithColorsWCModel>();
        }
    }
}
