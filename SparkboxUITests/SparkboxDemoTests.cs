using SparkboxFramework;
using Xunit;

namespace SparkboxUITests
{
    public class SparkboxDemoTests : SparkboxUITestBase
    {
        private const string GoogleUrl = "https://www.google.com";
        private const string UnixPapaUrl = "https://unixpapa.com/js/testmouse.html";

        [Fact]
        public void Selenium_Can_Do_Magic()
        {
            Browser.NavigateTo("https://www.google.com");
            Assert.Contains("https://www.google.com", Browser.GetCurrentUrl());

            WaitForSeconds(7);

            Browser.NavigateTo(Site.HomePage.Url);
            Assert.Contains(Site.HomePage.Url, Browser.GetCurrentUrl());

            WaitForSeconds(7);

            Browser.RefreshPage();
            Assert.Contains(Site.HomePage.Url, Browser.GetCurrentUrl());

            WaitForSeconds(7);

            Browser.SetResolution(320, 180);

            WaitForSeconds(2);

            Browser.MaximizeWindow();

            WaitForSeconds(7);

            Browser.ScrollDown();

            WaitForSeconds(2);

            Browser.ScrollDown();

            WaitForSeconds(2);

            Browser.ScrollUp();

            WaitForSeconds(2);

            Browser.ScrollUp();

            WaitForSeconds(7);

            var contactNavLink = Browser.GetElementByCssSelector(Site.ContactPage.NavBarCssSelector);
            Browser.HoverOver(contactNavLink);

            WaitForSeconds(7);

            Browser.NavigateTo(UnixPapaUrl);
            Assert.Contains(UnixPapaUrl, Browser.GetCurrentUrl());

            WaitForSeconds(7);

            var testLink = Browser.GetElementByCssSelector("body > table > tbody > tr > td:nth-child(1) > a:nth-child(1)");
            Browser.DoubleClick(testLink);

            WaitForSeconds(7);

            var testArea = Browser.GetElementByCssSelector("body > table > tbody > tr > td:nth-child(1) > form > textarea");
            var testAreaContents = testArea.GetAttributeValue("value");
            Assert.Contains("dblclick", testAreaContents);

            WaitForSeconds(7);
        }
    }
}
