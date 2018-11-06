using AutomatedUITestingAndYou.Interfaces;

namespace SparkboxFramework.Pages
{
    public class WorkPage : IPage
    {
        public string Url => "https://seesparkbox.com/work";
        public string NavBarCssSelector => "#nav > div.nav-container > ol > li:nth-child(3) > a";
    }
}
