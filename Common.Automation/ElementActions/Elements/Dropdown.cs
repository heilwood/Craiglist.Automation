using System;
using Common.Automation.ElementActions.ElementsBase;
using Common.Automation.Exceptions;
using OpenQA.Selenium;

namespace Common.Automation.ElementActions.Elements
{
    public class Dropdown : ClickElementBase
    {
        public Dropdown(IWebDriver driver, TimeSpan waitTime) : base(driver, waitTime)
        {
        }

        public void SelectValueUsingClick(By dropdown, By value)
        {
            ClickAndWait(dropdown);
            ClickAndWait(value);
        }

        public bool IsValueCanBeSelected(By dropdown, string valueText)
        {
            try
            {
                var elem = GetChildElementByText(dropdown, valueText);
                return IsElementClickable(elem);
            }
            catch (NoChildElementWithTextException)
            {
                throw new NoChildElementWithTextException($"Cannot find value in dropdown \"{dropdown}\" with text: {valueText}");
            }
            
        }
    }
}
