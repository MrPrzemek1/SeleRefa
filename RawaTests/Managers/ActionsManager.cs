using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Managers
{
    public class ActionsManager
    {
        private static Actions Action { get; set; }
        private static ActionsManager Instance;

        public static ActionsManager CreateAction()
        {
          return Instance = new ActionsManager();      
        }
        private ActionsManager()
        {
            Action = new Actions(DriverManager.CreateInstance().Driver);
        }

        public void DragAndDrop(IWebElement source, IWebElement taget)
        {
            Action.ClickAndHold(source).MoveToElement(taget).MoveByOffset(5, 5).Release(taget).Build().Perform();
        }
        public void RotateElement(IWebElement element)
        {
            Action.ClickAndHold(element)
                .MoveByOffset(100, -50)
                .Release()
                .Build()
                .Perform();
        }
    }
}
