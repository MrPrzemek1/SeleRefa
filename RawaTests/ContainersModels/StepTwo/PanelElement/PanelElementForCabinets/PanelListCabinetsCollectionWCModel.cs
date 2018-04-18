using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RawaTests.ContainersModels.StepTwo.PanelElement
{
    class PanelListCabinetsCollectionWCModel
    {
        IList<IWebElement> collection;
        IList<IWebElement> subCollection;
        IList<IWebElement> images;

        public PanelListCabinetsCollectionWCModel(IList<IWebElement> collection = null, IList<IWebElement> subCollection = null, IList<IWebElement> images = null)
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
