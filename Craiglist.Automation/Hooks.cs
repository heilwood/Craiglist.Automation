using System;
using Common.Automation;
using Common.Automation.Browsers;
using Common.Automation.Helpers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Craiglist.Automation
{
    [Binding]
    public class Hooks
    {
        private static IWebDriver _driver;
        private static ScreenshotHelper _screenshotHelper;
        private static BrowserName _browser;

        protected Hooks()
        {
            _screenshotHelper = new ScreenshotHelper();
            Enum.TryParse(ConfigManager.BrowserName, out _browser);
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = BrowserFactory.LocalDriver(_browser);
            _driver.Manage().Window.Maximize();
            DriverHolder.Intitialize(_driver, TimeSpan.FromSeconds(int.Parse(ConfigManager.WaitTime)));
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (ScenarioContext.Current.TestError != null) _screenshotHelper.TakeScreenshot(_driver);
            _driver?.Quit();
            DriverHolder.Utilize();
        }
    }
}