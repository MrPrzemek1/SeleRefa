using RawaTests.Helpers;
using RawaTests.Model.Login;
using RawaTests.WebElementsModels;

namespace RawaTests.Model
{
    class ActionOnWCLoginPage : LoginPageWCModel
    {
        public ActionOnWCLoginPage(NxWEInputModel company, NxWEInputModel Login, NxWEInputModel password, NxWEButtonModel loginButton, NxWELabelModel validateField = null)
        {
            CompanyNameInput = company;
            LoginInput = Login;
            PasswordInput = password;
            SubmitButton = loginButton;
            ValidateFieldElement = validateField;
        }

        public void SetCorrectLoginData()
        {
            CompanyNameInput.SendText(LoginData.CompanyName);
            LoginInput.SendText(LoginData.Login);
            PasswordInput.SendText(LoginData.Password);
        }

        public bool ValidateFieldIsDisplayed
        {
            get
            {
                if (ValidateFieldElement != null)
                    return ValidateFieldElement.Dispalyed();
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
            CompanyNameInput.SendText(company);
            LoginInput.SendText(login);
            PasswordInput.SendText(pass);
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
