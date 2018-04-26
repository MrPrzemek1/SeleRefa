using RawaTests.Managers;

namespace RawaTests.Services.Base
{
    public abstract class BaseService
    {
        private DriverManager Manager;

        public BaseService(DriverManager manager)
        {
            this.Manager = manager;
        }
    }
}
