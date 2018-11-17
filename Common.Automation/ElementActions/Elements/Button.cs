using System;
using Common.Automation.ElementActions.ElementsBase;
using OpenQA.Selenium;

namespace Common.Automation.ElementActions.Elements
{
    public class Button : ClickElementBase
    {
        public Button(IWebDriver driver, TimeSpan waitTime) : base(driver, waitTime)
        {
        }
    }
}
