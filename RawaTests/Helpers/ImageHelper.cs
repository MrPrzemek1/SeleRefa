﻿using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Managers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using XnaFan.ImageComparison;
using RawaTests.Helpers.DriverHelper;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests
{
    public class ImageHelper
    {
        /// <summary>
        /// Metoda robiąca screenshota i zwracająca scieżkę do niego
        /// </summary>
        /// <returns></returns>
        public static string MakeScreenshot()
        {
            DriverHelper.WaitUntil(DriverManager.CreateInstance().Driver, ExpectedConditions.InvisibilityOfElementLocated(By.XPath(Configurator3DConsts.LOADER)));
            string path = CreateRandomPath();
            Screenshot screan1 = ((ITakesScreenshot)DriverManager.CreateInstance().Driver).GetScreenshot();
            screan1.SaveAsFile(path, ScreenshotImageFormat.Jpeg);
            return path;
        }
        /// <summary>
        /// Metoda robiąca screenshota.
        /// </summary>
        /// <param name="path"> nazwa pliku</param>
        public static void MakeScreenshot(string path)
        {
            DriverHelper.WaitUntil(DriverManager.CreateInstance().Driver, ExpectedConditions.InvisibilityOfElementLocated(By.XPath(Configurator3DConsts.LOADER)));
            ((ITakesScreenshot)DriverManager.CreateInstance().Driver).GetScreenshot().SaveAsFile(PathConsts.SCREEN + path+".jpeg");
        }
        /// <summary>
        /// Metoda sprawdzająca czy dwa obrazku sa takie same. W parametrach przyjmuje ścieżki do plików
        /// </summary>
        /// <param name="pathFirst"></param>
        /// <param name="pathSecond"></param>
        /// <returns></returns>
        public static bool CheckingImagesAreDifferent(string pathFirst, string pathSecond)
        {
            float differencePixels = ImageTool.GetPercentageDifference(pathFirst, pathSecond);
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
    }
}
