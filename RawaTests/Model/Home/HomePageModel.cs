using RawaTests.Model.Base.Buttons;
using RawaTests.IWebElements;
using RawaTests.IWebElements.TextElements;

namespace RawaTests.Model.Home
{
    class HomePageModel : HomeModel
    {
        public HomePageModel(INxButton startBtn, INxWebImage homeImg, INxWebImage logoImg, IBaseWebElement footer, INxButton loginBtn)
        {
            StartButton = startBtn;
            HomePageImage = homeImg;
            LogoImage = logoImg;
            Footer = footer;
            LoginBtn = loginBtn;
        }
        public override bool IsValid()
        {
            return StartButton != null && HomePageImage.GetImageSource() != null;
        }
        
    }
}
