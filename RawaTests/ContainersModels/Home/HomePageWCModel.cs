using RawaTests.Model.Base;
using RawaTests.WebElementsModels;

namespace RawaTests.Model
{
    abstract public class HomePageWCModel : BaseWebContainerModel
    {
        public NxWEButtonModel StartButton { get; set; }
        public NxWEImageModel HomePageImage { get; set; }
        public NxWEImageModel LogoImage { get; set; }
        public NxWELabelModel Footer { get; set;}
        public NxWEButtonModel LoginBtn { get; set; }
        public NxWELabelModel Header { get; set; }
        public NxWELabelModel LogoutDiv { get; set; }
        public NxWEButtonModel LogoutButton { get; set; }
    }
}
