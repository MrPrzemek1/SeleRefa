using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Model.Login
{
    class LoginModel
    {
        public IWebElement CompanyName { get; set; }

        public IWebElement Login { get; set; }

        public IWebElement Password { get; set; }

        public IWebElement LoginButton { get; set; }

        public IWebElement ValidateField { get; set; }
    }
}
