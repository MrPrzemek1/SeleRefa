using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RawaTests.WebElementsModels;

namespace RawaTests.ContainersModels.StepTwo.PanelElement
{
    class PanelListCabinetsCollectionWCModel
    {
        NxWEButtonModel collection;
        IList<NxWEButtonModel> subCollection;
        IList<NxWEImageModel> images;

        public PanelListCabinetsCollectionWCModel(NxWEButtonModel collection=null, IList<NxWEButtonModel> subCollection=null, IList<NxWEImageModel> images=null)
        {
            this.collection = collection;
            this.subCollection = subCollection;
            this.images = images;
        }

        public void lalal()
        {
            subCollection.Where(e => e.Text.Equals("Zamkniete")).FirstOrDefault().Click();
        }
    }
}
