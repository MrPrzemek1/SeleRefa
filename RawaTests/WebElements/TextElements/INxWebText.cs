﻿using RawaTests.IWebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.WebElements.TextElements
{
    public interface INxWebText : IBaseWebElement
    {
        bool Contains(string text);
    }
}