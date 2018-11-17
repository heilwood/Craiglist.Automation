using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using OpenQA.Selenium;

namespace Common.Automation.ElementActions.ElementsBase
{
    public class TextElementBase : ElementBase
    {
        public TextElementBase(IWebDriver driver, TimeSpan waitTime) : base(driver, waitTime)
        {
        }

        public string RemoveDigitsFromText(string text)
        {
            return Regex.Replace(text, @"[\d-]", string.Empty);
        }

        public decimal GetDecimalFromText(string text)
        {
            return decimal.Parse(Regex.Match(text, @"\d+(\.\d+)?").Value);
        }

        public List<string> GetElementsText(By elemLocator)
        {
            var elems = GetLocatedElements(elemLocator);
            var elemsText = elems.Select(GetText).ToList();
            return elemsText;
        }

        public string GetText(IWebElement elem)
        {
            return elem.Text;
        }
    }
}
