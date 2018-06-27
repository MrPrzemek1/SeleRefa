using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.Models.StepTwo.Groups
{
    public class GroupOptionsWCModel
    {
        private IWebDriver _driver;
        public IList<GroupOptionWCModel> groupOption;

        public GroupOptionsWCModel(IWebDriver driver)
        {
            _driver = driver;
            groupOption = new List<GroupOptionWCModel>();
        }
        public void GetOptionColor() => MainClick(GroupType.KOLOR);

        public void GetOptionDoor() => MainClick(GroupType.DRZWI);

        public void GetOptionWindow() => MainClick(GroupType.OKNA);

        public void GetOptionCabinetsEco() => MainClick(GroupType.SZAFKI_ECO);

        public void GetOptionCabinetsSimply() => MainClick(GroupType.SZAFKI_SIPMLY);

        private void MainClick(GroupType type)
        {
            groupOption.Where(e => String.Equals(e.NameOfGroup.GetAttribute("value"), groupName[type], StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault().NameOfGroup.ClickIfElementIsClickable(_driver);
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
            string a = groupOption.Where(e => String.Equals(e.NameOfGroup.Text, groupName[type], StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault().NameOfGroup.GetAttribute("checked");
            bool result = false;
            if (a.Equals("checked"))
            {
                result = true;
            }
            return result;
        }
    }
}
