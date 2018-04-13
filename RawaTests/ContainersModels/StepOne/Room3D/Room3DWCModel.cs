using RawaTests.Model.Base;
using RawaTests.WebElementsModels;

namespace RawaTests
{
    public class Room3DWCModel : BaseWebContainerModel
    {
        public NxWEImageModel Room3dImage { get; set; }

        public override bool IsValid()
        {
            return Room3dImage != null;
        }
    }

}
