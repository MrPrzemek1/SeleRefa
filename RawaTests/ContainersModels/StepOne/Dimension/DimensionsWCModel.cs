using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.StepOne
{
    public class DimensionsWCModel
    {
        public IWebElement header { get; set; }

        public IList<DimensionWCModel> dimensionElements { get; set; }

        public DimensionsWCModel()
        {
            dimensionElements = new List<DimensionWCModel>();
        }
        /// <summary>
        /// Metoda wybierające pola do edycji wymiarów obrazka przy pomocy opisu ściany np: "A"
        /// </summary>
        /// <param name="desc">Litera opisująca ścianę</param>
        /// <returns></returns>
        public DimensionWCModel GetFieldByDescription(string desc) => dimensionElements.Where(e => e.description.Text.Equals(desc)).FirstOrDefault();
    }
}
