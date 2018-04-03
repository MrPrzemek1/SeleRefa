using NUnit.Framework;
using OpenQA.Selenium;
using RawaTests.IWebElements;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.Model.Base.Buttons
{
    public class NxButton : BaseWebElement, INxButton ,IEnumerable<NxButton>
    {
        private IWebElement element;
        private IList<IWebElement> listOfButton;
        public int Count => listOfButton.Count;

        public NxButton(IWebElement e) : base(e)
        {
            element = e;
        }

        public NxButton(IList<IWebElement> listOfButton) : base(listOfButton)
        {
            this.listOfButton = listOfButton;
        }
        public void Click()
        {
            element.Click();
        }
        public IWebElement this[int index]
        {
            get
            {
               return listOfButton[index];
            }
            set
            {
                listOfButton[index] = value;
            }
        }

        IEnumerator<NxButton> IEnumerable<NxButton>.GetEnumerator()
        {
            return (IEnumerator<NxButton>)GetEnumerator();
        }
        public IWebElement ListOfButton => listOfButton.ElementAtOrDefault(i);
        //public IList<IWebElement> this[int index] => listOfButton.ElementAt(index);
    }
}
