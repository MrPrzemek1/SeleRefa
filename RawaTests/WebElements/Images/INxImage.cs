using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.IWebElements
{
    public interface INxImage : IBaseWebElement
    {
        string GetElementAttribute(string atributte);
    }
}
