using OpenQA.Selenium;
using RawaTests.Model.Base;
using RawaTests.Model.Base.Buttons;
using RawaTests.WebElements.Input;
using RawaTests.WebElements.TextElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Model.Login
{
    abstract class LoginModel : BaseModel
    {
        public INxInput CompanyNameInput { get; set; }
        public INxInput LoginInput { get; set; }
        public INxInput PasswordInput { get; set; }
        public INxButton SubmitButton { get; set; }
        public INxLabels ValidateFieldElement { get; set; }
    }

}
