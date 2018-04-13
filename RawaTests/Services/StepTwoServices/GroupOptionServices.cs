using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Models.StepTwo;
using RawaTests.Models.StepTwo.Groups;
using RawaTests.Services.Base;
using RawaTests.WebElementsModels;
using System.Collections.Generic;

namespace RawaTests.Services.StepTwoServices
{
    public class GroupOptionServices : BaseService
    {
        public GroupOptionServices() : base()
        {

        }
        public GroupOptionsWCModel GetOptionModel()
        {
            var radio = new List<IWebElement>(Manager.FindWebElementsAndWait(By.XPath(StepTwoLocators.groupOption)));

            GroupOptionsWCModel model = new GroupOptionsWCModel();

            for (int i = 0; i < radio.Count; i++)
            {
                model.GroupOption.Add(new GroupOptionWCModel
                {
                    NameOfGroup = new NxWELabelModel(radio[i]),
                });
            }
            return model;           
        }
    }
}
