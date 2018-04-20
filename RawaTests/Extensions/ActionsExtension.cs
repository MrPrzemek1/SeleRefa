using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RawaTests.Extensions
{
    public static class ActionsExtension
    {
        public static void DragDropAndWait(this Actions action, IWebElement source, IWebElement target, int waitInMilliseconds)
        {
            action.DragAndDropToOffset(source, 480,180).Perform();
            for (int i = 0; i < 100; i++)
            {
                action.ClickAndHold(source).MoveByOffset(500, 170).Release().Click().Build().Perform();
                i++;
            }
        }
    }
}
