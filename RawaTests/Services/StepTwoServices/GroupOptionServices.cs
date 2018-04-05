using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.IWebElements.TextElements;
using RawaTests.Model.Base.Buttons;
using RawaTests.Models.StepTwo;
using RawaTests.Models.StepTwo.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RawaTests.Helpers.DriverHelper.DriverHelp;

namespace RawaTests.Services.StepTwoServices
{
    public class GroupOptionServices
    {
        public GroupOptionPageModel GetOptionModel()
        {
            Wait(2);
            var radio = new NxLabels(Driver.FindElements(By.XPath(StepTwoLocators.GroupOption)));

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
