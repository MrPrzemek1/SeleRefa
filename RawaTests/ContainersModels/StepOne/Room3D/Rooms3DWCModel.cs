using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.Model.Room3D
{
    public class Rooms3DWCModel
    {
        public IList<Room3DWCModel> Room3D { get; set; }

        public Rooms3DWCModel()
        {
            Room3D = new List<Room3DWCModel>();
        }
        /// <summary>
        /// Metoda zwracająca tablicę z atrybutami "style" które odzwierciedlają wielkość obrazka.
        /// </summary>
        /// <returns></returns>
        public string[] GetRoomDimension()
        {
            return Room3D.Select(e => e.Room3dImage.GetAttribute(HtmlAttributesConsts.STYLE)).ToArray();
        }
    }
}
