using RawaTests.Model.Base;
using RawaTests.WebElementsModels;

namespace RawaTests.Model.Login
{
    abstract class LoginPageWCModel : BaseWebContainerModel
    {
        public NxWEInputModel CompanyNameInput { get; set; }
        public NxWEInputModel LoginInput { get; set; }
        public NxWEInputModel PasswordInput { get; set; }
        public NxWEButtonModel SubmitButton { get; set; }
        public NxWELabelModel ValidateFieldElement { get; set; }
    }

}
