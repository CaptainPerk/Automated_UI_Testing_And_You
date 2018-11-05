using AutomatedUITestingAndYou.Interfaces;

namespace SparkboxFramework.Pages
{
    public class WhatWeDoPage : IPage
    {
        public string Url => "https://seesparkbox.com/what-we-do";
        public string NavBarCssSelector => "#nav > div.nav-container > ol > li:nth-child(2) > a";
    }
}
