using System;
using OpenQA.Selenium;

namespace Common.Automation.ElementActions.ElementsBase
{
    public class ClickElementBase : ElementBase
    {
        public ClickElementBase(IWebDriver driver, TimeSpan waitTime) : base(driver, waitTime)
        {
        }

        public void Click(By elemLocator)
        {
            GetLocatedElement(elemLocator).Click();
        }

        public void ClickAndWait(By elemLocator)
        {
            Click(elemLocator);
            WaitForAjax();
        }
    }

}
