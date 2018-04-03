using RawaTests.Model.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.StepOne
{
    class DimensionsPageModel : DimensionModel
    {
        public IList<DimensionModel> Elements { get; set; }

        public DimensionsPageModel()
        {
            Elements = new List<DimensionModel>();
        }
        //public DimensionModel this[string name]
        //{
        //    get
        //    {
        //        return Elements.Where(e => e.Name == name).FirstOrDefault();
        //    }
        //}
    }
}
