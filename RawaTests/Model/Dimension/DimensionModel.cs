using OpenQA.Selenium;
using RawaTests.Model.Base.Buttons;
using RawaTests.WebElements.Input;
using RawaTests.WebElements.TextElements;

using System;
namespace RawaTests.StepOne
{
    public class DimensionModel
    {
        public INxWebText Header {get;set;}
        public INxWebText Name { get; set; }
        public INxButton MinusSign { get; set; }
        public INxButton PlusSign { get; set; }
        public INxButton Input { get; set; }
    }
}
