using RawaTests.Model.Base;
using RawaTests.WebElementsModels;
using System;
namespace RawaTests.StepOne
{
    public class DimensionWCModel : BaseWebContainerModel
    {
        
        public NxWELabelModel Description { get; set; }
        public NxWEButtonModel MinusSign { get; set; }
        public NxWEButtonModel PlusSign { get; set; }
        public NxWEInputModel Input { get; set; }

        public override bool IsValid()
        {
            return Description != null && MinusSign != null && PlusSign != null && Input != null;
        }
    }
}
