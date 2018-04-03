using OpenQA.Selenium;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.IWebElements
{
    public class BaseWebElement : IBaseWebElement
    {
        private IWebElement element;
        IList<IWebElement> list;
        public BaseWebElement(IWebElement e) => element = e;
        public BaseWebElement(IList<IWebElement> list) => list = new List<IWebElement>();

        public string Text => element.Text;

        public bool Dispalyed()
        {
            return element.Displayed;
        }

        public string GetAttribute(string attribute)
        {
            return element.GetAttribute(attribute);
        }

        //public IWebElement LoadingImage()
        //{
        //    try
        //    {
        //        return Driver.FindElement(By.ClassName("loading-show"));
        //    }
        //    catch
        //    {
        //        return null ;
        //    }
        //}
        //public IWebElement Wait(int seconds)
        //{
        //    try
        //    {
        //        var loading = LoadingImage();
        //        DateTime date = DateTime.Now.AddSeconds(seconds);
        //        while (loading != null && date > DateTime.Now)
        //        {
        //            Thread.Sleep(200);
        //            loading = LoadingImage();
        //        }
        //        return element;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
    }
    }

