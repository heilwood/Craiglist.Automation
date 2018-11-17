using System;
using System.Configuration;
using Common.Automation.ElementActions.ElementsBase;
using OpenQA.Selenium;

namespace Common.Automation
{
    public class Navigation : ElementBase
    {
        public Navigation(IWebDriver driver, TimeSpan wait) : base(driver, wait)
        {
        }

        public void GotoRelatedUrl(string relatedUrl)
        {
            var combinedUrl = $"{ConfigurationManager.AppSettings["RedirectedPage"]}{relatedUrl}";
            GoToUrl(combinedUrl);
        }

        public void GoToUrl(string url)
        {
            Driver.Url = url;
            WaitForPageToLoad();
            Console.WriteLine($"Url name: {url}");
        }

        public string GetCurrentUrl()
        {
            return Driver.Url;
        }
    }
}
