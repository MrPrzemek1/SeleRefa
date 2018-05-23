using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Model.Base;

namespace RawaTests.Model.Login
{
    class LoginPageWCModel : BaseWebContainerModel
    {
        private IWebDriver driver;
        public IWebElement companyNameInput { get; set; }
        public IWebElement loginInput { get; set; }
        public IWebElement passwordInput { get; set; }
        public IWebElement submitButton { get; set; }
        public IWebElement validateFieldElement { get; set; }

        public LoginPageWCModel(IWebDriver driver, IWebElement company, IWebElement Login, IWebElement password, IWebElement loginButton, IWebElement validateField = null)
        {
            this.driver = driver;
            companyNameInput = company;
            loginInput = Login;
            passwordInput = password;
            submitButton = loginButton;
            validateFieldElement = validateField;
        }

        public void SetCorrectLoginData()
        {
            companyNameInput.SendKeys(LoginData.CompanyName);
            loginInput.SendKeys(LoginData.Login);
            passwordInput.SendKeys(LoginData.Password);
        }

        public bool ValidateFieldIsDisplayed
        {
            get
            {
                if (validateFieldElement != null)
                    return validateFieldElement.Displayed;
                else
                    return false;
            }
        }
        public string ValidateText
        {
            get
            {
                if (ValidateFieldIsDisplayed)
                    return validateFieldElement.Text;
                else
                    return null;
            }
        }
        public void ClearAllLoginForField()
        {
            companyNameInput.Clear();
            loginInput.Clear();
            passwordInput.Clear();
        }
        public void SetLoginData(string company, string login, string pass)
        {
            companyNameInput.SendKeys(company);
            loginInput.SendKeys(login);
            passwordInput.SendKeys(pass);
        }
        public override bool IsValid() => loginInput != null;

        public void ClearLoginInput() => loginInput.Clear();
        public void SubmitLoginForm() => submitButton.ClickIfElementIsClickable(driver);
    }

}
