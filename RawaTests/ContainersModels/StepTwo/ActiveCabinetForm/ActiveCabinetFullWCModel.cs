using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo.ActiveElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo
{
    public class ActiveCabinetFullWCModel
    {
        IWebElement Header { get; set; }
        public ActiveCabinetRightTableWCModel RightPanel { get; set; }
        public ActiveCabinetLeftTableWCModel LeftPanel { get; set; }
        public ActiveCabinetFullWCModel(IWebElement header, ActiveCabinetRightTableWCModel right, ActiveCabinetLeftTableWCModel left)
        {
            Header = header;
            LeftPanel = left;
            RightPanel = right;
        }
        public string HeaderText{ get { return Header.Text; } }
    }
}
