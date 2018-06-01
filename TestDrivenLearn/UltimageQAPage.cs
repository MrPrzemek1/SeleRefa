using OpenQA.Selenium;
using System;

namespace TestDrivenLearn
{
    internal class UltimageQAPage : BaseSampleApplicationPage
    {
        public UltimageQAPage(IWebDriver driver) : base(driver) { }

        public bool IsLoaded => Driver.Title.Equals(string.Format("Home - Ultimate QA",StringComparison.CurrentCultureIgnoreCase)) && Driver.FindElement(By.LinkText("Start learning now")).Displayed;
    }
}