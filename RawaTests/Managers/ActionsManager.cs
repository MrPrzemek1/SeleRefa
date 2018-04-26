using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RawaTests.Helpers.DriverHelper;
using RawaTests.HtmlStrings.ConstStrings;
using System.Threading;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests.Managers
{
    public class ActionsManager : Actions
    {
        public static IWebDriver driver = DriverManager.CreateInstance().Driver;
        private static Actions Action { get; set; }
        private static ActionsManager Instance;

        public static ActionsManager CreateAction()
        {
          return Instance = new ActionsManager(driver);      
        }
        private ActionsManager(IWebDriver driver) : base(driver)
        {
            driver = DriverManager.CreateInstance().Driver;
            Action = new Actions(driver);
        }
        /// <summary>
        /// Metoda ktora przenosi i upuszcza element na drugi element. Po znalezieniu się nad elementem docelowym wykonywane jest przesunięcie obiektu nad nim w celu umieszczenia przenoszonego elemetu na elemencie docelowym
        /// </summary>
        /// <param name="source">element który chcemy przenieść</param>
        /// <param name="target">element na który chcemy przenieść</param>
        /// <param name="xPosiotion">przesuniecie po osi X w pixelach</param>
        /// <param name="yPostion">przesuniecie po osi Y w pixelach</param>
        public void CustomDragAndDropForWindowAndDoor(IWebElement source, IWebElement target, int xPosiotion = 5, int yPostion = 5)
        {
            Action.ClickAndHold(source).MoveToElement(target).MoveByOffset(xPosiotion, yPostion).Release(target).Build().Perform();       
         }
        public void CustomDragAndDropForCabinets(IWebElement source, IWebElement target, int xPosiotion = 5, int yPostion = 5)
        {

                CreateAction().ClickAndHold(source).MoveToElement(target).MoveByOffset(10,10).Perform();
                Thread.Sleep(500);
                CreateAction().Release(target).Perform();
                //Action.ClickAndHold(source).MoveToElement(taget).MoveByOffset(xPosiotion, yPostion).Release(taget).Build().Perform();
                //i++;
        }
        /// <summary>
        /// Metoda która obraca element o podane współrzędne
        /// </summary>
        /// <param name="element">obracany element</param>
        /// <param name="xPosiotion">obrót po osi X w pixelach</param>
        /// <param name="yPostion">obrót po osi Y w pixelach</param>
        public void RotateElement(IWebElement element, int xPosiotion = 100, int yPostion = -50)
        {
            DriverHelper.WaitUntil(DriverManager.CreateInstance().Driver, ExpectedConditions.InvisibilityOfElementLocated(By.ClassName(Configurator3DConsts.LOADER)));
            Action.ClickAndHold(element)
                .MoveByOffset(xPosiotion, yPostion)
                .Release()
                .Build()
                .Perform();
        }
    }
}
