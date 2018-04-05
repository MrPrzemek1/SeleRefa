using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Helpers
{
    public class GroupNameHelper
    {
        Dictionary<int, string> groupName = new Dictionary<int, string>()
        {
            {1,""},
            {2,""},
            {3,""},
            {4,""},
            {5,""},
        };

        

        public void Add()
        {
            groupName.Add(1,"asd");
            groupName.Add(2, "asd");
            groupName.Add(3, "asd");
            groupName.Add(4, "asd");
            groupName.Add(5, "asd");
        }


    }
}
