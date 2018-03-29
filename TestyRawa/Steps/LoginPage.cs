using OpenQA.Selenium;
using System;
using static TestyRawa.DriverHelper.Browser;

namespace TestyRawa
{
    class LoginPage
    {
        private string Company = "rmg";
        private string Worker = "Radosław Gierach";
        private string Pass = "MADZIAZZ";
        //private string ValidateComunicat = "Nie udało się zalogować";
        //IWebDriver driver { get { return Driver; } }
        private IWebElement LoginForm => Driver.FindElement(By.XPath("//form[@class='loginForm']"));
        private IWebElement CompanyName => Driver.FindElement(By.XPath("//input[@placeholder='Nazwa firmy']"));
        private IWebElement WorkerName => Driver.FindElement(By.XPath("//input[@placeholder='Nazwa pracownika']"));
        private IWebElement Password => Driver.FindElement(By.XPath("//input[@placeholder='Hasło']"));
        private IWebElement LoginButton => Driver.FindElement(By.XPath("//input[@type='submit']"));
        private IWebElement ValidateComunicat => Driver.FindElement(By.XPath("//ul[@class='alert alert-danger']"));
        public bool VerifyLoginFormIsDisplayed()
        {
            var present = false;
            if (LoginForm.Displayed)
            {
                return true;
            }
            else
                for (int i = 0; i < 3; i++)
                {                    
                    try
                    {
                       present = LoginForm.Displayed;
                    }
                    catch (NoSuchElementException e)
                    {
                    }
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    i++;
                }
            return false;
        }
        public void CorrectLogin()
        {
            try
            {
                CompanyName.SendKeys(Company);
                WorkerName.SendKeys(Worker);
                Password.SendKeys(Pass);
                LoginButton.Click();
            }
            catch (Exception e)
            {
            }
        }
        public void SetWrongDataToLogin(string WrongCompanyName,string WrongWorker,string WrongPassword)
        {
            try
            {
                CompanyName.SendKeys(WrongCompanyName);
                WorkerName.SendKeys(WrongWorker);
                Password.SendKeys(WrongPassword);
                LoginButton.Click();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public string GetValidateComunicat()
        {
           return ValidateComunicat.Text;
        }
    }
}
