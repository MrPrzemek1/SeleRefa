using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.Models.StepTwo.PanelElement
{
    public class PanelWindowWCModel
    {
        IWebElement DivWithElements { get; set; }
        IList<IWebElement> WindowImageList { get; set; }

        public PanelWindowWCModel(IWebElement divWithElements, IList<IWebElement> windowImageList)
        {
            DivWithElements = divWithElements;
            WindowImageList = windowImageList;
        }
        public IWebElement GetWindowById(string id)
        {
            return WindowImageList.Where(e => e.GetAttribute(HtmlAttributesConsts.OBJECT_ID).Equals(id)).FirstOrDefault();
        }
        private List<string> GetWindowId()
        {
            return WindowImageList.Select(e => e.GetAttribute(HtmlAttributesConsts.OBJECT_ID)).ToList();
        }
        public IWebElement GetRandomWindow()
        {
            List<string> windowsId = GetWindowId();
            Random r = new Random();
            string randomWindow = windowsId[r.Next(0, windowsId.Count)];
            return WindowImageList.Where(e => e.GetAttribute(HtmlAttributesConsts.OBJECT_ID).Equals(randomWindow)).FirstOrDefault();
        }
    }
}
