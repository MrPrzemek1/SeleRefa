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
            var radio = _manager.FindWebElementsAndWait(By.Name(StepTwoLocators.groupOptionLocator));

            GroupOptionsWCModel model = new GroupOptionsWCModel(_manager.Driver);

            for (int i = 0; i < radio.Count; i++)
            {
                model.groupOption.Add(new GroupOptionWCModel
                {
                    NameOfGroup = radio[i],
                });
            }
            return model;           
        }
    }
}
