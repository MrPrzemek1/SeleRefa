using RawaTests.ContainersModels.StepTwo.ColorPicker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo
{
    public class ColorPickerWCModel
    {
        private AllRowsWithColorsWCModel allRowsWithColorsWCModels { get; set; }
        public AllColorsInSingleRowWCModel allColors { get; set; }
  
        public ColorPickerWCModel(AllRowsWithColorsWCModel allRowsWithColorsWCModels, AllColorsInSingleRowWCModel allColors)
        {
            this.allRowsWithColorsWCModels = allRowsWithColorsWCModels;
            this.allColors = allColors;
        }
    }

}
