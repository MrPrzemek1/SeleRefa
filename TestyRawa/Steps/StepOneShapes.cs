using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using static TestyRawa.DriverHelper.Browser;
using System.Linq;
using System.Drawing;

namespace TestyRawa
{
    public class StepOneShapes 
    {
        
        private IList<IWebElement> RoomParamsList => Driver.FindElements(By.XPath("//input[@type='number']"));
        private IList<IWebElement> RoomMinusList => Driver.FindElements(By.XPath("//input[@type='button' and @value='-']"));
        private IList<IWebElement> RoomPlusList => Driver.FindElements(By.XPath("//input[@type='button' and @value='+']"));
        private IList<IWebElement> ShapesRoomList => Driver.FindElements(By.XPath("//li[@shape-id]"));
        private IList<IWebElement> DemensionOfRoom => Driver.FindElements(By.XPath("//div[@class='letter']"));
        private IWebElement Room3DView => Driver.FindElement(By.XPath("//div[@class='room3dView']"));
        private IWebElement costam => Driver.FindElement(By.ClassName("asdasd"));
        private IWebElement ksztalt;
        public IWebElement Kształt
        {
            get
            {
                return ksztalt;
            }
            set
            {
                Driver.FindElement(By.XPath("//li[@shape-id]"));
            }
        }
        //StepOneShapes(IWebElement Shape, By Image, IList<IWebElement> Dimension) : base (Shape, Image, Dimension)
        //{
        //    this.ksztalt = Shape;
        //}

        public bool ViewRoomList()
        {
            WaitUntilElementIsDisplayed((By.XPath("//div[@class='room3dView']")), 5);

            ShapesRoomList.Select(e => e.GetAttribute("ACTIVE"));
            return ShapesRoomList.All((element) => 
            {
                element.Click();
                return element.GetAttribute("class").Equals("active");
            });
        }
        /// <summary>
        /// Metoda wybierająca drugie pomieszczenie z listy pomieszczeń i klikająca w przycisk minus zmieniający długość ściany o -1.
        /// </summary>
        public void ClickOnMinusButtonToTheFieldWithSizeOfWall(int numberOfShape, int numberOfMinus)
        {
            ShapesRoomList[numberOfShape].Click();
            RoomMinusList[numberOfMinus].Click();
        }
        /// <summary>
        /// Metoda zwracająca listę stringów z wymiarami obrazka
        /// </summary>
        /// <returns></returns>
        public List<string> GetDimensionImageSize()
        {
            List<string> Demension = new List<string>();
            foreach (var item in DemensionOfRoom)
            {
                Demension.Add(item.GetAttribute("style"));
            }
            return Demension;
        }
        /// <summary>
        /// Metoda porównująca dwie listy stringów zawierające wymiary obrazka
        /// </summary>
        /// <param name="list1">Lista z domyślnymi wymiarami obrazka</param>
        /// <param name="list2">Lista z wymiarami obrazka po zmianie</param>
        /// <returns></returns>
        public bool CompareImageDimension(List<string> list1, List<string> list2)
        {
            bool IsCompare = true;
            if (!list1.SequenceEqual(list2))
            {
                return IsCompare;
            }
            else
                IsCompare = false;
                return false;
        }
    }
}
