using AutomatedUITestingAndYou.Interfaces;

namespace SparkboxFramework.Pages
{
    public class ResourcesPage : IPage
    {
        public string Url => "https://seesparkbox.com/resources";
        public string NavBarCssSelector => "#nav > div.nav-container > ol > li:nth-child(5) > a";
    }
}
