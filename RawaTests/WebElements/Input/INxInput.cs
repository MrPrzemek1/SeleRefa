using RawaTests.IWebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.WebElements.Input
{
    public interface INxInput : IBaseWebElement
    {
        void SendText(string text);
        void Clear();
    }
}
