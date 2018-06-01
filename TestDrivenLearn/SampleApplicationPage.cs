using OpenQA.Selenium;
using System;

namespace TestDrivenLearn
{
    internal class SampleApplicationPage : BaseSampleApplicationPage
    {
        public SampleApplicationPage(IWebDriver driver) : base(driver) { }

        public bool IsLoaded => Driver.Title.Equals("Sample Application Lifecycle - Sprint 2 - Ultimate QA");

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("https://www.ultimateqa.com/sample-application-lifecycle-sprint-2/");
        }
        public IWebElement FirstNameInput => Driver.FindElement(By.Name("firstname"));
        public IWebElement LastNameInput => Driver.FindElement(By.Name("lastname"));
        public IWebElement SubmitButton => Driver.FindElement(By.XPath("//input[@type='submit']"));

        
        internal UltimageQAPage FillOutFormAndSubmit(TestUser user)
        {
            FirstNameInput.SendKeys(user.Name);
            LastNameInput.SendKeys(user.LastName);
            SubmitButton.Submit();
            return new UltimageQAPage(Driver);
        }
    }
}