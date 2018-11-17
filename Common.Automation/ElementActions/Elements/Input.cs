using System;
using Common.Automation.ElementActions.ElementsBase;
using OpenQA.Selenium;

namespace Common.Automation.ElementActions.Elements
{
    public class Input : InputElementBase
    {
        public Input(IWebDriver driver, TimeSpan waitTime) : base(driver, waitTime)
        {
        }
    }
}
