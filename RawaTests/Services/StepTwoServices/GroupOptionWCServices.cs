using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Managers;
using RawaTests.Models.StepTwo;
using RawaTests.Models.StepTwo.Groups;
using RawaTests.Services.Base;

namespace RawaTests.Services.StepTwoServices
{
    public class GroupOptionWCServices : BaseService
    {
        public GroupOptionWCServices(DriverManager manager) : base(manager) { }

        public GroupOptionsWCModel GetOptionModel()
        {
            var radio = Manager.FindWebElementsAndWait(By.Name(StepTwoLocators.groupOption));

            GroupOptionsWCModel model = new GroupOptionsWCModel(Manager.Driver);

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
