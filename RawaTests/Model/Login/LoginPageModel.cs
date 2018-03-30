using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Model.Base.Buttons;
using RawaTests.Model.Login;

namespace RawaTests.Model
{
    class LoginPageModel : LoginModel
    {
        public LoginPageModel(IWebElement company, IWebElement Login, IWebElement password, INxButton loginButton, IWebElement loginbuttonelement, IWebElement validateField = null)
        {
            CompanyNameElement = company;
            LoginElement = Login;
            PasswordElement = password;
            LoginButton = loginButton;
            this.LoginButtonElement = loginbuttonelement;
            ValidateFieldElement = validateField;
        }

        public void SetLoginData(LoginPageModel model)
        {
            model.CompanyNameElement.SendKeys(LoginData.CompanyName);
            model.LoginElement.SendKeys(LoginData.Login);
            model.PasswordElement.SendKeys(LoginData.Password);
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
            CompanyNameElement.Clear();
            LoginElement.Clear();
            PasswordElement.Clear();
        }

        public void SetLoginData(string company, string login, string pass)
        {
            CompanyNameElement.SendKeys(company);
            LoginElement.SendKeys(login);
            PasswordElement.SendKeys(pass);
        }
        public override bool IsValid()
        {
            return LoginButtonElement != null && LoginElement != null;
        }
    }
}
