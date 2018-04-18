using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Model.Login;

namespace RawaTests.Model
{
    class ActionOnWCLoginPage : LoginPageWCModel
    {
        public ActionOnWCLoginPage(IWebElement company, IWebElement Login, IWebElement password, IWebElement loginButton, IWebElement validateField = null)
        {
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
        }
        public override bool IsValid()
        {
            return LoginInput != null;
        }
        public void ClearLoginInput()
        {
            LoginInput.Clear();
        }
    }
}
