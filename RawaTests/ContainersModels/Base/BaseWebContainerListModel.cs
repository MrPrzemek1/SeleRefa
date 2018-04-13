using RawaTests.WebElementsModels;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.Models.Base
{
    public abstract class BaseListModel<TModel> where TModel : NxBaseWebElementModel
    {
        public IList<TModel> Elements { get; set; }

        public BaseListModel(IList<TModel> elements)
        {
            Elements = elements;
        }

        //public bool IsAllValid()
        //{
        //   // return Elements.All(e => e.);
        //}
    }
}
