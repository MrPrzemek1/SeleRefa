using RawaTests.WebElementsModels;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.StepOne
{
    public class DimensionsWCModel : DimensionWCModel
    {
        public NxWELabelModel Header { get; set; }

        public IList<DimensionWCModel> DimensionElements { get; set; }
        public IList<DimensionWCModel> HeightElements { get; set; }

        public DimensionsWCModel HeightRoomElement { get; set; }

        public DimensionsWCModel()
        {
            DimensionElements = new List<DimensionWCModel>();
            HeightElements = new List<DimensionWCModel>();
        }
        /// <summary>
        /// Metoda wybierające pola do edycji wymiarów obrazka przy pomocy opisu ściany np: "A"
        /// </summary>
        /// <param name="desc">Litera opisująca ścianę</param>
        /// <returns></returns>
        public DimensionWCModel GetFieldByDescription(string desc)
        {
            return DimensionElements.Where(e => e.Description.Text.Equals(desc)).FirstOrDefault();
        }
        public DimensionWCModel GetRoom(string desc)
        {
            return DimensionElements.Where(e => e.Description.Text.Equals(desc)).FirstOrDefault();
        }
        public override bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}
