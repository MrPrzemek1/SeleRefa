using RawaTests.Managers;

namespace RawaTests.Services.Base
{
    public abstract class BaseService
    {
        protected DriverManager Manager { get; set; }

        public BaseService()
        {
            Manager = DriverManager.CreateInstance();
        }
    }
}
