using RawaTests.ContainersModels.StepTwo.ColorPicker;

namespace RawaTests.ContainersModels.StepTwo
{
    public class ColorPickerWCModel
    {
        private AllRowsWithColorsWCModel allRowsWithColorsWCModels { get; set; }
        public AllColorsInSingleRowWCModel allColors { get; set; }
        public RightPanelColorPickerWCModel rightPanel { get; set; }
        public ColorPickerWCModel(AllRowsWithColorsWCModel allRowsWithColorsWCModels, AllColorsInSingleRowWCModel allColors, RightPanelColorPickerWCModel rightPanel)
        {
            this.allRowsWithColorsWCModels = allRowsWithColorsWCModels;
            this.allColors = allColors;
            this.rightPanel = rightPanel;
        }
    }
}
