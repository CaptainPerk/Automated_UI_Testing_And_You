using AutomatedUITestingAndYou.Interfaces;

namespace SparkboxFramework.Pages
{
    public class ContactPage : IPage
    {
        public string Url => "https://seesparkbox.com/work-with-us";
        public string NavBarCssSelector => "#nav > div.nav-container > ol > li:nth-child(6) > a";

        public string NameTextboxCssSelector => "#main-content > div > form > div:nth-child(2) > input";
        public string CompanyTextboxCssSelector => "#main-content > div > form > div:nth-child(3) > input";
        public string EmailTextboxCssSelector => "#main-content > div > form > div:nth-child(4) > input";       
        public string PhoneTextboxCssSelector => "#main-content > div > form > div:nth-child(5) > input";       
    }
}
