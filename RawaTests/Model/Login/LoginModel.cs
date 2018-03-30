using OpenQA.Selenium;
using RawaTests.Model.Base;
using RawaTests.Model.Base.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Model.Login
{
    abstract class LoginModel : BaseModel
    {
        protected IWebElement CompanyNameElement { get; set; }
        protected IWebElement LoginElement { get; set; }
        protected IWebElement PasswordElement { get; set; }
        public INxButton LoginButton { get; set; }
        protected IWebElement LoginButtonElement { get; set; }
        protected IWebElement ValidateFieldElement { get; set; }
    }

}
