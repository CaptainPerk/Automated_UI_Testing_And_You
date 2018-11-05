using AutomatedUITestingAndYou.Interfaces;

namespace SparkboxFramework.Pages
{
    public class ContactPage : IPage
    {
        public string Url => "https://seesparkbox.com/work-with-us";
        public string NavBarCssSelector => "#nav > div.nav-container > ol > li:nth-child(6) > a";
    }
}
