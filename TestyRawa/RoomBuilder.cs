using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestyRawa.DriverHelper.Browser;
namespace TestyRawa
{
    abstract public class RoomBuilder
    {
        protected IWebElement Shape;
        protected By Image;
        protected IList<IWebElement> Dimension;
        public RoomBuilder(IWebElement Shape, By Image, IList<IWebElement> Dimension)
        {
            this.Shape = Shape;
            this.Image = Image;
            this.Dimension = Dimension;
        }
        abstract public IWebElement GetShape(int shapeId);
        abstract public IWebElement GetImage();
        abstract public IList<IWebElement> GetListOfDimension();
    }
}
