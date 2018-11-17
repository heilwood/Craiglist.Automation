using System;
using OpenQA.Selenium;

namespace Common.Automation.ElementActions.ElementsBase
{
    public class InputElementBase : ElementBase
    {
        public InputElementBase(IWebDriver driver, TimeSpan waitTime) : base(driver, waitTime)
        {
        }

        public void Type(By elemLocator, string text)
        {
            GetLocatedElement(elemLocator).SendKeys(text);
            Console.WriteLine($"Entered: {text}");
        }
    }
}
