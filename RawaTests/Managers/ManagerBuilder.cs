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
