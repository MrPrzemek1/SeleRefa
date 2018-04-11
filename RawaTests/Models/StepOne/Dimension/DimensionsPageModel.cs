using OpenQA.Selenium;
using RawaTests.Model.Base;
using RawaTests.WebElements.TextElements;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.StepOne
{
    public class DimensionsPageModel
    {
        public INxLabels Header { get; set; }

        public IList<DimensionModel> Elements { get; set; }

        public DimensionModel HeightRoomElement { get; set; }

        public DimensionsPageModel()
        {
            Elements = new List<DimensionModel>();
        }
        /// <summary>
        /// Metoda wybierające pola do edycji wymiarów obrazka przy pomocy opisu ściany np: "A"
        /// </summary>
        /// <param name="desc">Litera opisująca ścianę</param>
        /// <returns></returns>
        public DimensionModel GetFieldByDescription(string desc)
        {
            return Elements.Where(e => e.Description.Text.Equals(desc)).FirstOrDefault();
        }
    }
}
