using AutomatedUITestingAndYou.Enumerations;

namespace AutomatedUITestingAndYou.Interfaces
{
    public interface IBrowserAutomator
    {
        void InstantiateNewBrowser(BrowserType browserType, string url);
        string GetCurrentUrl();
        void NavigateTo(string url);
        void RefreshPage();
        void MaximizeWindow();
        void SetResolution(int width, int height);
        void ScrollUp();
        void ScrollDown();
        void DoubleClick(IPageElement element);
        void HoverOver(IPageElement element);
        void EnterText(IPageElement element, string text);
        IPageElement GetElementByCssSelector(string cssSelector);
        void Close();
    }
}
