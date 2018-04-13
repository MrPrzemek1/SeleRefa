namespace RawaTests.WebElementsModels
{
    public interface IBaseWebElement
    {
        string Text { get; }
        string GetAttribute(string attribute);
        bool Dispalyed();
        void Click();
    }
}
