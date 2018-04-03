﻿using RawaTests.IWebElements;
using RawaTests.Model.Base;
using RawaTests.Model.Base.Buttons;
using RawaTests.WebElements.TextElements;

namespace RawaTests.Model
{
    abstract public class HomeModel : BaseModel
    {
        public INxButton StartButton { get; set; }
        public INxWebImage HomePageImage { get; set; }
        public INxWebImage LogoImage { get; set; }
        public INxLabels Footer { get; set;}
        public INxButton LoginBtn { get; set; }
        public INxLabels Header { get; set; }
        public INxLabels Logout { get; set; }
    }
}
