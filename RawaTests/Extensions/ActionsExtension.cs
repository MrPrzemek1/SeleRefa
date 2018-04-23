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
            action.ClickAndHold(source)
                .MoveByOffset(550, 150)
                .Release()
                .Build()
                .Perform();
            action.DragAndDropToOffset(source, 560, 145).Perform();
            action.DragAndDropToOffset(source, 565, 135).Perform();
            action.DragAndDropToOffset(source, 570, 130).Perform();
            action.DragAndDrop(source, target).Perform();

        }
    }
}
