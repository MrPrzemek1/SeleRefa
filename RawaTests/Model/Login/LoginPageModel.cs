using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.Model.Login;

namespace RawaTests.Model
{
    class LoginPageModel : LoginModel
    {
        public void SetLoginData(LoginPageModel model)
        {
            model.CompanyName.SendKeys(LoginData.CompanyName);
            model.Login.SendKeys(LoginData.Login);
            model.Password.SendKeys(LoginData.Password);
        }

        public bool ValidateFieldIsDisplayed
        {
            get
            {
                if (ValidateField != null)
                    return ValidateField.Displayed;
                else
                    return false;
            }
        }

        public string ValidateText
        {
            get
            {
                if (ValidateFieldIsDisplayed)
                    return ValidateField.Text;
                else
                    return null;
            }
        }

        public void ClearAllLoginForField()
        {
            CompanyName.Clear();
            Login.Clear();
            Password.Clear();
        }

        public void SetLoginData(string company, string login, string pass)
        {
            CompanyName.SendKeys(company);
            Login.SendKeys(login);
            Password.SendKeys(pass);
        }
    }
}
