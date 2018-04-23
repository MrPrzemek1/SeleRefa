using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
