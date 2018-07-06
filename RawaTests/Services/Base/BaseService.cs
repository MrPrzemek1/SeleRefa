using NLog;
using RawaTests.Managers;

namespace RawaTests.Services.Base
{
    public abstract class BaseService
    {
        public DriverManager _manager;
        public Logger logger = LogManager.GetCurrentClassLogger();
        public BaseService(DriverManager manager)
        {
            this._manager = manager;
        }
    }
}
