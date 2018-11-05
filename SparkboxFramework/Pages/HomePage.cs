using AutomatedUITestingAndYou.Interfaces;

namespace SparkboxFramework.Pages
{
    public class HomePage : IPage
    {
        public string Url => "https://seesparkbox.com/";
        public string NavBarCssSelector => "#nav > div.main-logo > a";
    }
}
