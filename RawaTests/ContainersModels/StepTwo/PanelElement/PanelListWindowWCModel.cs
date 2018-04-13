using RawaTests.Models.Base;
using RawaTests.WebElementsModels;
using System.Collections.Generic;

namespace RawaTests.Models.StepTwo.PanelElement
{
    public class PanelListWindowWCModel : BaseListModel<NxWEImageModel>
    {
        NxWELabelModel ListOfElements { get; set; }
        IList<NxWEImageModel> WindowList { get; set; }

        public PanelListWindowWCModel(NxWELabelModel div, IList<NxWEImageModel> images) : base(images)
        {
            ListOfElements = div;
            WindowList = images;
        }
    }
}
