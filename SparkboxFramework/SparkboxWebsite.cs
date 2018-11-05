using AutomatedUITestingAndYou.Interfaces;
using SparkboxFramework.Pages;

namespace SparkboxFramework
{
    public class SparkboxWebsite
    {
        public ContactPage ContactPage = new ContactPage();
        public FoundryPage FoundryPage = new FoundryPage();
        public HomePage HomePage = new HomePage();
        public ResourcesPage ResourcesPage = new ResourcesPage();
        public TeamPage TeamPage = new TeamPage();
        public WhatWeDoPage WhatWeDoPage = new WhatWeDoPage();
        public WorkPage WorkPage = new WorkPage();

        public void UseNavigationBarToNavigateTo(IBrowserAutomator browserAutomator, IPage page)
        {
            browserAutomator.GetElementByCssSelector(page.NavBarCssSelector).Click();
        }
    }
}
