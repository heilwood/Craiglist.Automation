using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Common.Automation.Browsers
{
    public class ChromeSettings : IBrowserSettings
    {
        public DriverOptions GetBrowserSettings()
        {
            var options = new ChromeOptions();
            //options.AddArgument("--headless");
            return options;
        }
    }
}
