using RawaTests.WebElementsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo.PanelElement
{
    public class PanelListCabinetsWCModel
    {
        NxWELabelModel FiltrPanel { get; set; }
        NxWEButtonModel FiltrButton { get; set; }
        IList<NxWEButtonModel> FiltrDropown { get; set; }
        NxWELabelModel CollectionGroup { get; set; }
        NxWEButtonModel CollectionSubGroup { get; set; }
        IList<NxWEImageModel> CabinetsImages { get; set; }

        PanelListCabinetsWCModel(NxWELabelModel filtrPanel, NxWEButtonModel filtrButton, List<NxWEButtonModel> filtrDropdown, NxWELabelModel collectionGroup, NxWEButtonModel collectionSub, List<NxWEImageModel> images)
        {
            FiltrPanel = filtrPanel;
            FiltrButton = filtrButton;
            FiltrDropown = filtrDropdown;
            CollectionGroup = collectionGroup;
            CollectionSubGroup = collectionSub;
            CabinetsImages = images;
        }

    }
}
