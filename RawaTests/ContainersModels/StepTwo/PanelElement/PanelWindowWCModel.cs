using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.Models.StepTwo.PanelElement
{
    public class PanelWindowWCModel
    {
        IWebElement ListOfElements { get; set; }
        IList<IWebElement> WindowList { get; set; }

        public PanelWindowWCModel(IWebElement div, IList<IWebElement> images)
        {
            ListOfElements = div;
            WindowList = images;
        }
        public IWebElement GetWindowById(string id)
        {
            return WindowList.Where(e => e.GetAttribute(HtmlAttributesConsts.OBJECT_ID).Equals(id)).FirstOrDefault();
        }
        private List<string> GetWindowId()
        {
            return WindowList.Select(e => e.GetAttribute(HtmlAttributesConsts.OBJECT_ID)).ToList();
        }
        public IWebElement GetRandomWindow()
        {
            List<string> windowsId = GetWindowId();
            Random r = new Random();
            string randomWindow = windowsId[r.Next(0, windowsId.Count)];
            return WindowList.Where(e => e.GetAttribute(HtmlAttributesConsts.OBJECT_ID).Equals(randomWindow)).FirstOrDefault();
        }
    }
}
