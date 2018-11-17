using System;
using System.Collections.ObjectModel;
using System.Configuration;
using Common.Automation.Exceptions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Common.Automation.ElementActions.ElementsBase
{
    public class ElementBase
    {
        protected static IWebDriver Driver;
        private readonly WebDriverWait _wait;

        public ElementBase(IWebDriver driver, TimeSpan waitTime)
        {
            Driver = driver;
            _wait = new WebDriverWait(driver, waitTime);
        }

        public IWebElement GetLocatedElement(By elemLocator)
        {
            WaitUntilElementIsVisible(elemLocator);
            var element = Driver.FindElement(elemLocator);
            return element;
        }

        public ReadOnlyCollection<IWebElement> GetLocatedElements(By elemLocator)
        {
            WaitUntilElementIsVisible(elemLocator);
            var element = Driver.FindElements(elemLocator);
            return element;
        }

        public void WaitForPageToLoad()
        {
            new WebDriverWait(Driver,
                TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings["PageLoadWaitTime"])))
            {
                Message = "Stuck on page loading"
            }
                .Until(
                    d =>
                        ((IJavaScriptExecutor)Driver).ExecuteScript("return document.readyState").ToString().Equals("complete"));
        }

        public void WaitForAjax()
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings["PageLoadWaitTime"])))
            {
                Message = "Stuck on page loading, ajax"
            }
            .Until(driver => (bool)((IJavaScriptExecutor)driver).
                ExecuteScript("return jQuery.active == 0"));
        }

        public void WaitUntilElementIsVisible(By elemLocator)
        {
            try
            {
                _wait.Until(ExpectedConditions.ElementIsVisible(elemLocator));
            }
            catch (WebDriverTimeoutException)
            {
                throw new WebDriverTimeoutException($"Element not found with by->{elemLocator}");
            }
            catch (StaleElementReferenceException)
            {
                throw new StaleElementReferenceException($"Element not found with by->{elemLocator}");
            }
            catch (NoSuchElementException)
            {
                throw new NoSuchElementException($"Element not found with by->{elemLocator}");
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException($"Element not found with by->{elemLocator}");
            }
        }

        public bool IsElementClickable(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }

        public By GetByContainsTxt(string text)
        {
            var by = By.XPath($"//*[contains(text(),'{text}')]");
            return by;
        }

        public IWebElement GetChildElementByText(By parentElemLocator, string childText)
        {
            var elem = GetLocatedElement(parentElemLocator);
            try
            {
                return elem.FindElement(GetByContainsTxt(childText));
            }
            catch (NoSuchElementException)
            {
                throw new NoChildElementWithTextException($"Cannot find element with text: {childText}");
            }
        }

        public int GetElementAmount(By elemLocator)
        {
            return GetLocatedElements(elemLocator).Count;
        }
    }
}
