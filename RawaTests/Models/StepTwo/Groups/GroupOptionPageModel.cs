using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            GroupOption.Where(e => String.Equals(e.NameOfGroup.Text, "Kolorystyka ścian i podłóg", StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault().NameOfGroup.Click();           
        }
        public void GetOptionDoor()
        {
            GroupOption.Where(e => String.Equals(e.NameOfGroup.Text, "Drzwi", StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault().NameOfGroup.Click();
        }
        public void GetOptionWindow()
        {
            GroupOption.Where(e => String.Equals(e.NameOfGroup.Text, "Okna", StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault().NameOfGroup.Click();
        }
        public void GetOptionCabinetsEco()
        {
            GroupOption.Where(e => String.Equals(e.NameOfGroup.Text, "Szafki kuchenne eco", StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault().NameOfGroup.Click();
        }
        public void GetOptionCabinetsSimple()
        {
            //GroupOption.Where(e => String.Equals(e.NameOfGroup.Text, "Szafki kuchenne Simply", StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault().NameOfGroup.Click();
            MainClick(GroupType.SZAFKI_SIPMLY);
        }
        private void MainClick(GroupType type)
        {
            GroupOption.Where(e => String.Equals(e.NameOfGroup.Text, groupName[type], StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault().NameOfGroup.Click();
        }

        private enum GroupType
        {
            KOLOR = 1,
            DZRWI,
            OKNA,
            SZAFKI_ECO,
            SZAFKI_SIPMLY
        }

        private Dictionary<GroupType, string> groupName = new Dictionary<GroupType, string>()
        {
            {GroupType.DZRWI,"Drzwi"},
            {GroupType.KOLOR,"Drzwi"},
            {GroupType.OKNA,"Drzwi"},
            {GroupType.SZAFKI_ECO,"Drzwi"},
            {GroupType.SZAFKI_SIPMLY,"Szafki kuchenne simply"}
        };
    }
}
