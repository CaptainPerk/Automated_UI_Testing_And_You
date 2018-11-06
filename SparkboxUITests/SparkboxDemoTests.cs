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
            Browser.NavigateTo(GoogleUrl);
            Assert.Contains(GoogleUrl, Browser.GetCurrentUrl());
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

            var teamNavLink = Browser.GetElementByCssSelector(Site.TeamPage.NavBarCssSelector);
            Browser.HoverOver(teamNavLink);

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

        [Fact]
        public void Can_Navigate_Using_The_Navbar()
        {
            Site.UseNavigationBarToNavigateTo(Browser, Site.TeamPage);
            WaitForSeconds(2);
            Assert.Contains(Site.TeamPage.Url, Browser.GetCurrentUrl());
            Site.UseNavigationBarToNavigateTo(Browser, Site.WhatWeDoPage);
            WaitForSeconds(2);
            Assert.Contains(Site.WhatWeDoPage.Url, Browser.GetCurrentUrl());
            Site.UseNavigationBarToNavigateTo(Browser, Site.WorkPage);
            WaitForSeconds(2);
            Assert.Contains(Site.WorkPage.Url, Browser.GetCurrentUrl());
            Site.UseNavigationBarToNavigateTo(Browser, Site.FoundryPage);
            WaitForSeconds(2);
            Assert.Contains(Site.FoundryPage.Url, Browser.GetCurrentUrl());
            Site.UseNavigationBarToNavigateTo(Browser, Site.ResourcesPage);
            WaitForSeconds(2);
            Assert.Contains(Site.ResourcesPage.Url, Browser.GetCurrentUrl());
            Site.UseNavigationBarToNavigateTo(Browser, Site.ContactPage);
            WaitForSeconds(2);
            Assert.Contains(Site.ContactPage.Url, Browser.GetCurrentUrl());
            Site.UseNavigationBarToNavigateTo(Browser, Site.HomePage);
            WaitForSeconds(2);
            Assert.Contains(Site.HomePage.Url, Browser.GetCurrentUrl());
        }

        [Fact]
        public void Can_Fill_Out_Contact_Form()
        {
            Site.UseNavigationBarToNavigateTo(Browser, Site.ContactPage);
            WaitForSeconds(2);
            Assert.Contains(Site.ContactPage.Url, Browser.GetCurrentUrl());
            var nameTextBox = Browser.GetElementByCssSelector(Site.ContactPage.NameTextboxCssSelector);
            Browser.EnterText(nameTextBox, "Perk");
            WaitForSeconds(1);
            var companyTextBox = Browser.GetElementByCssSelector(Site.ContactPage.CompanyTextboxCssSelector);
            Browser.EnterText(companyTextBox, "Hand Cannon Games");
            WaitForSeconds(1);
            var emailTextBox = Browser.GetElementByCssSelector(Site.ContactPage.EmailTextboxCssSelector);
            Browser.EnterText(emailTextBox, "perk@handcannongames.com");
            WaitForSeconds(1);
            var phoneTextBox = Browser.GetElementByCssSelector(Site.ContactPage.PhoneTextboxCssSelector);
            Browser.EnterText(phoneTextBox, "937-555-1234");
            WaitForSeconds(10);
        }
    }
}
