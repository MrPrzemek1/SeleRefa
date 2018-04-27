using OpenQA.Selenium;
using RawaTests.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static RawaTests.Helpers.DriverHelper.DriverHelper;

namespace RawaTests.Models.StepTwo.Groups
{
    public class GroupOptionsWCModel
    {
        public IList<GroupOptionWCModel> GroupOption;
        private IWebDriver Driver;
        public GroupOptionsWCModel(IWebDriver driver)
        {
            this.Driver = driver;
            GroupOption = new List<GroupOptionWCModel>();
        }
        public void GetOptionColor()
        {
            MainClick(GroupType.KOLOR);
        }
        public void GetOptionDoor()
        {
            MainClick(GroupType.DRZWI);
        }
        public void GetOptionWindow()
        {
            MainClick(GroupType.OKNA);
        }
        public void GetOptionCabinetsEco()
        {
            MainClick(GroupType.SZAFKI_ECO);
        }
        public void GetOptionCabinetsSimply()
        {
            MainClick(GroupType.SZAFKI_SIPMLY);
        }
        private void MainClick(GroupType type)
        {
            GroupOption.Where(e => String.Equals(e.NameOfGroup.GetAttribute("value"), groupName[type], StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault().NameOfGroup.ClickIfElementIsClickable(Driver);
        }

        public enum GroupType
        {
            KOLOR = 1,
            DRZWI,
            OKNA,
            SZAFKI_ECO,
            SZAFKI_SIPMLY
        }
        private Dictionary<GroupType, string> groupName = new Dictionary<GroupType, string>()
        {
            {GroupType.KOLOR,"color"},
            {GroupType.DRZWI,"door"},
            {GroupType.OKNA,"window"},
            {GroupType.SZAFKI_ECO,"Szafki kuchenne eco"},
            {GroupType.SZAFKI_SIPMLY,"Szafki kuchenne simply"}
        };
        public bool IsChecked(GroupType type)
        {
            string a = GroupOption.Where(e => String.Equals(e.NameOfGroup.Text, groupName[type], StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault().NameOfGroup.GetAttribute("checked");
            bool result = false;
            if (a.Equals("checked"))
            {
                result = true;
            }
            return result;
        }
    }
}
