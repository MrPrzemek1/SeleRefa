using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RawaTests.WebElements.TextElements;

namespace RawaTests.IWebElements.TextElements
{
   public class NxLabels : BaseWebElement,INxLabels
    {
        private IWebElement element;
        private IList<IWebElement> listOfLabels;
        public int Count => listOfLabels.Count;

        public NxLabels(IWebElement e) : base(e)
        {
            element = e;
        }
        public NxLabels(IList<IWebElement> e) : base(e)
        {
            listOfLabels = e;
        }
        public bool Contains(string text)
        {
            return element.Text.Contains(text);
        }
        public IWebElement this[int index]
        {
            get
            {
                if (index < 0 || index>=listOfLabels.Count)
                {
                    return null;
                }
                return listOfLabels[index];
            }
            set
            {
                listOfLabels[index] = value;
            }
        }
    }
}
