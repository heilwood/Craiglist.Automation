using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Tracing;

namespace Common.Automation.Helpers
{
    public class ScreenshotHelper
    {
        private readonly string _assemblyName;

        public ScreenshotHelper()
        {
            _assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
        }

        public void TakeScreenshot(IWebDriver driver)
        {
            try
            {
                var fileNameBase = ScenarioContext.Current.ScenarioInfo.Title.ToIdentifier();

                var assembly = Assembly.GetExecutingAssembly();
                var dir = $@"{Path.GetDirectoryName(assembly.Location)}\Screenshots";
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                if (!(driver is ITakesScreenshot takesScreenshot)) return;
                var screenshot = takesScreenshot.GetScreenshot();

                var assemblyName = _assemblyName;

                var screenshotFilePath = Path.Combine(dir, $"{fileNameBase}{assemblyName}.png");

                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);

                Console.WriteLine("Screenshot: {0}", new Uri(screenshotFilePath));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while taking screenshot: {0}", ex);
            }
        }
    }
}
