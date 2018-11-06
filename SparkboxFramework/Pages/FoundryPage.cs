using AutomatedUITestingAndYou.Interfaces;

namespace SparkboxFramework.Pages
{
    public class FoundryPage : IPage
    {
        public string Url => "https://seesparkbox.com/foundry";
        public string NavBarCssSelector => "#nav > div.nav-container > ol > li:nth-child(4) > a";
    }
}
