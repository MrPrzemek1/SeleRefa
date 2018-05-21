using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Managers;
using System;
using XnaFan.ImageComparison;
using RawaTests.Helpers.DriverHelper;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests
{
    public class ImageHelper
    {
        private IWebDriver Driver;
        public ImageHelper(IWebDriver driver)
        {
            this.Driver = driver;       
        }
        /// <summary>
        /// Metoda robiąca screenshota i zwracająca scieżkę do niego
        /// </summary>
        /// <returns></returns>
        public static string MakeScreenshot(IWebDriver driver)
        {
            WaitBeforScreen(driver);
            string path = CreateRandomPath();
            Screenshot screan1 = ((ITakesScreenshot)driver).GetScreenshot();
            screan1.SaveAsFile(path, ScreenshotImageFormat.Jpeg);
            return path;
        }
        /// <summary>
        /// Metoda robiąca screenshota.
        /// </summary>
        /// <param name="path"> nazwa pliku</param>
        public static void MakeScreenshot(IWebDriver driver,string path)
        { 
           WaitBeforScreen(driver);
           DriverHelper.WaitUntil(driver, ExpectedConditions.InvisibilityOfElementLocated(By.XPath(Configurator3DConsts.LOADER)));
           ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(PathConsts.SCREEN + path+".jpeg");
        }
        /// <summary>
        /// Metoda sprawdzająca czy dwa obrazku sa takie same. W parametrach przyjmuje ścieżki do plików
        /// </summary>
        /// <param name="pathFirst"></param>
        /// <param name="pathSecond"></param>
        /// <returns></returns>
        public static bool CheckingImagesAreDifferent(string pathFirst, string pathSecond)
        {
            float differencePixels = ImageTool.GetPercentageDifference(pathFirst, pathSecond, 0);
            bool result = true;
            if (differencePixels!=0)
            {
                return result;
            }
            else
                result = false;
            return result;
        }
        /// <summary>
        /// Metoda generująca unikatową nazwę dla pliku.
        /// </summary>
        /// <returns></returns>
        private static string CreateRandomPath()
        {       
            string path = string.Format(@"E:\ScreanshotSelenium\{0}.jpeg", Guid.NewGuid());
            return path;
        }
        private static void WaitBeforScreen(IWebDriver driver)
        {
            ActionManager.Create(driver).SendKeys(Keys.Home).Perform();
            DriverHelper.WaitUntil(driver, ExpectedConditions.InvisibilityOfElementLocated(By.XPath(Configurator3DConsts.LOADER)));
        }
    }
}
