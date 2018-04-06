using RawaTests.Model.Base.Buttons;
using RawaTests.IWebElements;
using RawaTests.IWebElements.TextElements;
using RawaTests.WebElements.TextElements;

namespace RawaTests.Model.Home
{
    class HomePageModel : HomeModel
    {
        public HomePageModel(INxButton startBtn, INxImage homeImg, INxImage logoImg, INxLabels footer, INxButton loginBtn, INxLabels header) //, INxLabels logout
        {
            StartButton = startBtn;
            HomePageImage = homeImg;
            LogoImage = logoImg;
            Footer = footer;
            LoginBtn = loginBtn;
            Header = header;
           // Logout = logout;
        }
        public override bool IsValid()
        {
            return StartButton != null && HomePageImage.GetElementAttribute("src") != null;
        }
        
    }
}
