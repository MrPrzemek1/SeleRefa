using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.IWebElements
{
    public interface IBaseWebElement
    {
        string Text();
        string GetAttribute(string attribute);
        bool Dispalyed();
        IWebElement Wait(By by, int second = 5);
        IWebElement LoadingImage();
    }
}
