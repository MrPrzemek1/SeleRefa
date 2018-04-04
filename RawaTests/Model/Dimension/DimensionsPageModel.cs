using OpenQA.Selenium;
using RawaTests.Model.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.StepOne
{
    public class DimensionsPageModel : DimensionModel
    {
        public IList<DimensionModel> Elements { get; set; }

        public DimensionsPageModel()
        {
            Elements = new List<DimensionModel>();
        }
        public DimensionModel GetFieldByDescription(string desc)
        {
            return Elements.Where(e => e.Description.Text.Equals(desc)).FirstOrDefault();
        }
    }
}
