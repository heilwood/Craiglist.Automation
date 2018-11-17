using OpenQA.Selenium;

namespace Common.Automation.Browsers
{
    public interface IBrowserSettings
    {
        DriverOptions GetBrowserSettings();
    }
}
