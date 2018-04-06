using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static RawaTests.Helpers.DriverHelper.DriverHelp;

namespace RawaTests.Models.StepTwo.Groups
{
    public class GroupOptionPageModel
    {
        public IList<GroupOptionModel> GroupOption;
        public GroupOptionPageModel()
        {
            GroupOption = new List<GroupOptionModel>();
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
        public void GetOptionCabinetsSimple()
        {
            //GroupOption.Where(e => String.Equals(e.NameOfGroup.Text, "Szafki kuchenne Simply", StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault().NameOfGroup.Click();
            MainClick(GroupType.SZAFKI_SIPMLY);
        }
        private void MainClick(GroupType type)
        {
            GroupOption.Where(e => String.Equals(e.NameOfGroup.GetAttribute("value"), groupName[type], StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault().NameOfGroup.Click();
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
            {GroupType.KOLOR,"Kolorystyka ścian i podłóg"},
            {GroupType.DRZWI,"Drzwi"},
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
        public bool atr()
        {
            var a = FindElement(By.XPath("//div[contains(@class,'left-table-step2-container')]"));
            bool result = true;
            if (a.Text.Equals("Aby zmienić kolorystykę wybranej ściany kliknij na wybrany element."))
            {
                return result;
            }
            return false;
        }
    }
}
