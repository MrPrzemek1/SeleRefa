using OpenQA.Selenium;
using System;
using static RawaTests.Helpers.DriverHelper.DriverHelp;

namespace RawaTests.Helpers
{
    public static class AlertHelper
    {
        public static IAlert alert;

        public static bool HandleAlert()
        {
            try
            {
                alert = Driver.SwitchTo().Alert();
                return true;
            }
            catch (Exception)
            {
                return false;               
            }
        }
        public static void AcceptAlert()
        {
            bool IsAlertPresent = HandleAlert();
            if (IsAlertPresent == true)
            {
                alert.Accept();
            }
        }
    }
}
