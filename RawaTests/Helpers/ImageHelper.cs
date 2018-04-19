using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Managers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using XnaFan.ImageComparison;

namespace RawaTests.Helpers
{
    public class ImageHelper
    {
        public static bool ImageCompare(Bitmap bmp1, Bitmap bmp2, Double TolerasnceInPercent)
        {
            bool equals = true;
            bool flag = true;  //Inner loop isn't broken

            //Test to see if we have the same size of image
            if (bmp1.Size == bmp2.Size)
            {
                for (int x = 0; x < bmp1.Width; ++x)
                {
                    for (int y = 0; y < bmp1.Height; ++y)
                    {
                        Color Bitmap1 = bmp1.GetPixel(x, y);
                        Color Bitmap2 = bmp2.GetPixel(x, y);

                        if (Bitmap1.A != Bitmap2.A)
                        {
                            if (!CalculateTolerance(Bitmap1.A, Bitmap2.A, TolerasnceInPercent))
                            {
                                flag = false;
                                equals = false;
                                break;
                            }
                        }
                        if (Bitmap1.R != Bitmap2.R)
                        {
                            if (!CalculateTolerance(Bitmap1.R, Bitmap2.R, TolerasnceInPercent))
                            {
                                flag = false;
                                equals = false;
                                break;
                            }
                        }
                        if (Bitmap1.G != Bitmap2.G)
                        {
                            if (!CalculateTolerance(Bitmap1.G, Bitmap2.G, TolerasnceInPercent))
                            {
                                flag = false;
                                equals = false;
                                break;
                            }
                        }
                        if (Bitmap1.B != Bitmap2.B)
                        {
                            if (!CalculateTolerance(Bitmap1.B, Bitmap2.B, TolerasnceInPercent))
                            {
                                flag = false;
                                equals = false;
                                break;
                            }
                        }

                    }
                    if (!flag)
                    {
                        break;
                    }
                }
            }
            else
            {
                equals = false;
            }
            return equals;
        }
        private static bool CalculateTolerance(Byte FirstImagePixel, Byte SecondImagePixel, Double TolerasnceInPercent)
        {
            double OneHundredPercent;
            double DifferencesInPix;
            double DifferencesPercentage;


            if (FirstImagePixel > SecondImagePixel)
            {
                OneHundredPercent = FirstImagePixel;
            }
            else
            {
                OneHundredPercent = SecondImagePixel;
            }

            if (FirstImagePixel > SecondImagePixel)
            {
                DifferencesInPix = FirstImagePixel - SecondImagePixel;
            }
            else
            {
                DifferencesInPix = SecondImagePixel - FirstImagePixel;
            }

            DifferencesPercentage = (DifferencesInPix * 100) / OneHundredPercent;

            DifferencesPercentage = Math.Round(DifferencesPercentage, 2);

            if (DifferencesPercentage > TolerasnceInPercent)
            {
                return false;
            }

            return true;
        }

        public static void MakeScreenshot(string path)
        {
            Screenshot screan1 = ((ITakesScreenshot)DriverManager.CreateInstance().Driver).GetScreenshot();
            screan1.SaveAsFile(path, ScreenshotImageFormat.Jpeg);
        }

        public static bool CheckingImagesAreDifferent()
        {
            float differencePixels = ImageTool.GetPercentageDifference(PathConsts.SCREENONE, PathConsts.SCREENTWO);
            bool result = true;
            if (differencePixels!=0)
            {
                return result;
            }
            else
                result = false;
            return result;
        }
    }
}
