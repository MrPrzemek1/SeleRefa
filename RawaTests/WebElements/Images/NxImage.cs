using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.IWebElements
{
    public class NxImage : BaseWebElement, INxImage
    {
        private IWebElement element;
        private IList<IWebElement> listOfImages;
        public int Count => listOfImages.Count;
        public NxImage(IWebElement element) : base (element)
        {
            this.element = element;
        }
        public NxImage (IList<IWebElement> list) : base(list)
        {
            listOfImages = list;
        }
        public string GetImageSource()
        {
            return element.GetAttribute("src");
        }

        public IWebElement this[int index]
        {
            get
            {
                return listOfImages[index];
            }
        }
        public string GetElementAttribute(string attributeName)
        {
            return element.GetAttribute(attributeName);
        }
        public override void Click()
        {
            element.Click();
            Wait(1);
        }
    }
}
