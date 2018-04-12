using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.IWebElements.TextElements;
using RawaTests.Model.Base.Buttons;
using RawaTests.Models.StepTwo;
using RawaTests.Models.StepTwo.Groups;
using RawaTests.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RawaTests.Helpers.DriverHelper.DriverHelper;

namespace RawaTests.Services.StepTwoServices
{
    public class GroupOptionServices : BaseService
    {
        public GroupOptionServices() : base()
        {

        }
        public GroupOptionPageModel GetOptionModel()
        {
            var radio = new List<IWebElement>(Manager.FindWebElementsAndWait(By.XPath(StepTwoLocators.groupOption)));

            GroupOptionPageModel model = new GroupOptionPageModel();
            for (int i = 0; i < radio.Count; i++)
            {
                model.GroupOption.Add(new GroupOptionModel
                {
                    NameOfGroup = new NxLabels(radio[i]),
                });
            }
            return model;           
        }
    }
}
