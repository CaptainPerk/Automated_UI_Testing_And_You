using AutomatedUITestingAndYou.Interfaces;
using OpenQA.Selenium;

namespace AutomatedUITestingAndYou.Adapters
{
    public class SeleniumElement : IPageElement
    {
        internal IWebElement Element { get; }

        public SeleniumElement(IWebElement element)
        {
            Element = element;
        }

        public void Click() => Element.Click();

        public bool Displayed() => Element.Displayed;

        public string GetAttributeValue(string attributeName) => Element.GetAttribute(attributeName);
    }
}
