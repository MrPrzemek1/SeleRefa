using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.StepOne
{
    public class DimensionsWCModel
    {
        public IWebElement Header { get; set; }

        public IList<DimensionWCModel> DimensionElements { get; set; }

        public DimensionsWCModel()
        {
            DimensionElements = new List<DimensionWCModel>();
        }
        /// <summary>
        /// Metoda wybierające pola do edycji wymiarów obrazka przy pomocy opisu ściany np: "A"
        /// </summary>
        /// <param name="desc">Litera opisująca ścianę</param>
        /// <returns></returns>
        public DimensionWCModel GetFieldByDescription(string desc) => DimensionElements.Where(e => e.Description.Text.Equals(desc)).FirstOrDefault();
    }
}
