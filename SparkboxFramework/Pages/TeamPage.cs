using AutomatedUITestingAndYou.Interfaces;

namespace SparkboxFramework.Pages
{
    public class TeamPage : IPage
    {
        public string Url => "https://seesparkbox.com/team";
        public string NavBarCssSelector => "#nav > div.nav-container > ol > li:nth-child(1) > a";
    }
}
