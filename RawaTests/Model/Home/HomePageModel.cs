using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Model.Home
{
    public class HomePageModel : HomeModel
    {
        public bool StartButtonIsDisplay()
        {
            if (!StartButton.Displayed || StartButton == null)
                return false;
            else
                return true;
        }
    }
}
