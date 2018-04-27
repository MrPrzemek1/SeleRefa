using RawaTests.Managers;
using RawaTests.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Services.Builder
{
    public class ServiceBuilder
    {
        private static Dictionary<Type, Dictionary<DriverType, BaseService>> ServicesDictionary;

        public static T BuildService<T>(DriverManager manager) where T: BaseService
        {
            if(ServicesDictionary == null)
            {
                ServicesDictionary = new Dictionary<Type, Dictionary<DriverType, BaseService>>();
            }
            if(!ServicesDictionary.ContainsKey(typeof(T)))
            {
                ServicesDictionary.Add(typeof(T), new Dictionary<DriverType, BaseService>());
            }

            var srvDict = ServicesDictionary[typeof(T)];

            if (!srvDict.ContainsKey(manager.Type))
            {
                srvDict.Add(manager.Type, (Activator.CreateInstance(typeof(T), manager) as T));
            }

            return srvDict[manager.Type] as T;
        }
        public static void ClearDictionary()
        {
            ServicesDictionary.Clear();
        }
    }
}
