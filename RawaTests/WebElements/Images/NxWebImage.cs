using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.IWebElements
{
    public class NxWebImage : BaseWebElement, INxWebImage
    {
        private IWebElement element;
        private IList<IWebElement> listOfImages;
        public int Count => listOfImages.Count;
        public NxWebImage(IWebElement element) : base (element)
        {
            this.element = element;
        }
        public NxWebImage (IList<IWebElement> list) : base(list)
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
    }
}
