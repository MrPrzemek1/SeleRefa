using OpenQA.Selenium;

namespace RawaTests.IWebElements
{
    public abstract class BaseWebElement : IBaseWebElement
    {
        private IWebElement element;
        public BaseWebElement (IWebElement e)
        {
            element = e;
        }
        public bool Dispalyed()
        {
            return element.Displayed;
        }
        string IBaseWebElement.Text => element.Text;

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

