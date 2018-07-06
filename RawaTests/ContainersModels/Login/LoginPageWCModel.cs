using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Model.Base;

namespace RawaTests.Model.Login
{
    class LoginPageWCModel : BaseWebContainerModel
    {
        private IWebDriver _driver;
        public IWebElement CompanyNameInput { get; set; }
        public IWebElement LoginInput { get; set; }
        public IWebElement PasswordInput { get; set; }
        public IWebElement SubmitButton { get; set; }
        public IWebElement ValidateFieldElement { get; set; }

        public LoginPageWCModel(IWebDriver driver, IWebElement company, IWebElement Login, IWebElement password, IWebElement loginButton, IWebElement validateField = null)
        {
            _driver = driver;
            CompanyNameInput = company;
            LoginInput = Login;
            PasswordInput = password;
            SubmitButton = loginButton;
            ValidateFieldElement = validateField;
        }

        public void SetCorrectLoginData()
        {
            CompanyNameInput.SendKeys(LoginData.CompanyName);
            LoginInput.SendKeys(LoginData.Login);
            PasswordInput.SendKeys(LoginData.Password);
        }

        public bool ValidateFieldIsDisplayed
        {
            get
            {
                if (ValidateFieldElement != null)
                    return ValidateFieldElement.Displayed;
                else
                    return false;
            }
        }
        public string ValidateText
        {
            get
            {
                if (ValidateFieldIsDisplayed)
                    return ValidateFieldElement.Text;
                else
                    return null;
            }
        }
        public void ClearAllLoginForField()
        {
            CompanyNameInput.Clear();
            LoginInput.Clear();
            PasswordInput.Clear();
        }
        public void SetLoginData(string company, string login, string pass)
        {
            CompanyNameInput.SendKeys(company);
            LoginInput.SendKeys(login);
            PasswordInput.SendKeys(pass);
            SubmitButton.Click();
        }
        public override bool IsValid() => LoginInput != null;

        public void ClearLoginInput() => LoginInput.Clear();
        public void SubmitLoginForm() => SubmitButton.ClickIfElementIsClickable(_driver);
    }

}
