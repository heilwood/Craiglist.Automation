using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Common.Automation.Browsers
{
    public class BrowserFactory
    {
        public static IWebDriver LocalDriver(BrowserName browser)
        {
            switch (browser)
            {
                case BrowserName.Chrome:
                    var assembly = Assembly.GetExecutingAssembly();
                    var chromeDriverPath = Path.GetDirectoryName(assembly.Location);
                    var chromeOptions = (ChromeOptions)new ChromeSettings().GetBrowserSettings();
                    return new ChromeDriver(chromeDriverPath, chromeOptions);
            }
            throw new Exception($"Unknown browser name {browser}");
        }
    }
}
