using OpenQA.Selenium;
using RawaTests.Model.Base;
using RawaTests.Model.Base.Buttons;
using RawaTests.WebElements.Input;
using RawaTests.WebElements.TextElements;

using System;
namespace RawaTests.StepOne
{
    public class DimensionModel : BaseModel
    {
        public INxLabels Header {get;set;}
        public INxLabels Description { get; set; }
        public INxButton MinusSign { get; set; }
        public INxButton PlusSign { get; set; }
        public INxInput Input { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        //public DimensionModel(INxLabels header, INxLabels Name, INxButton minus, INxButton plus, INxInput input, INxLabels labels)
        //{
        //    this.Header = header;
        //    this.Name = Name;
        //    this.MinusSign = minus;
        //    this.PlusSign = plus;
        //    this.Input = input;
        //    this.labels = labels;
        //}
    }
}
