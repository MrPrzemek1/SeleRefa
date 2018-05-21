using RawaTests.Managers;

namespace RawaTests.Services.Base
{
    public abstract class BaseService
    {
        public DriverManager Manager;

        public BaseService(DriverManager manager)
        {
            this.Manager = manager;
        }
    }
}
