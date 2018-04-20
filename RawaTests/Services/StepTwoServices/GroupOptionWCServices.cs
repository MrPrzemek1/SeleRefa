using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Models.StepTwo;
using RawaTests.Models.StepTwo.Groups;
using RawaTests.Services.Base;
using System.Collections.Generic;

namespace RawaTests.Services.StepTwoServices
{
    public class GroupOptionWCServices : BaseService
    {
        public GroupOptionWCServices() : base()
        {

        }
        public GroupOptionsWCModel GetOptionModel()
        {
            var radio = Manager.FindWebElementsAndWait(By.Name(StepTwoLocators.groupOption));

            GroupOptionsWCModel model = new GroupOptionsWCModel();

            for (int i = 0; i < radio.Count; i++)
            {
                model.GroupOption.Add(new GroupOptionWCModel
                {
                    NameOfGroup = radio[i],
                });
            }
            return model;           
        }
    }
}
