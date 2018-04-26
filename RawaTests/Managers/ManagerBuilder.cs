using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Managers
{
    public static class ManagerBuilder
    {
        public static DriverManager CreateDriverManager(DriverType type)
        {
            return new DriverManager(type);
        }
    }
}
