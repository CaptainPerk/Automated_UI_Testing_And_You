using AutomatedUITestingAndYou.Adapters;
using AutomatedUITestingAndYou.Enumerations;
using AutomatedUITestingAndYou.Interfaces;
using System;
using System.Threading;

namespace SparkboxFramework
{
    public class SparkboxUITestBase : IDisposable
    {
        protected IBrowserAutomator Browser;
        protected SparkboxWebsite Site;

        public SparkboxUITestBase()
        {
            Browser = new SeleniumAutomator();
            Site = new SparkboxWebsite();
            Browser.InstantiateNewBrowser(BrowserType.Chrome, "https://seesparkbox.com/");
            Browser.MaximizeWindow();
        }

        public void WaitForSeconds(int seconds) => Thread.Sleep(seconds * 1000);

        public void Dispose() => Browser.Close();
    }
}
