using System.Configuration;

namespace Craiglist.Automation
{
    public class ConfigManager
    {
        public static string MainPage = ConfigurationManager.AppSettings["MainPage"];
        public static string RedirectedPage = ConfigurationManager.AppSettings["RedirectedPage"];
        public static string WaitTime = ConfigurationManager.AppSettings["WaitTime"];
        public static string BrowserName = ConfigurationManager.AppSettings["Browser"];
        public static string HousingPage = ConfigurationManager.AppSettings["HousingPage"];
    }
}