using OpenQA.Selenium;
using System;
namespace RawaTests.StepOne
{
    class DimensionModel : IComparable<DimensionModel>
    {
        public string Name { get; set; }
        public IWebElement MinusSign { get; set; }
        public IWebElement PlusSign { get; set; }
        public IWebElement Input { get; set; }

        public int CompareTo(DimensionModel obj)
        {
            return this.Name.CompareTo(obj.Name);
        }
    }
}
