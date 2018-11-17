using System;
using OpenQA.Selenium;

namespace Common.Automation
{

    public class DriverHolder
    {
        private static IWebDriver _driver;
        private static TimeSpan _waitTime;


        public static T CreateObject<T>()
        {
            var obj = (T)Activator.CreateInstance(typeof(T), _driver, _waitTime);
            return obj;
        }

        public static void Intitialize(IWebDriver driver, TimeSpan wait)
        {
            if (_driver == null)
            {
                _driver = driver;
                _waitTime = wait;
                return;
            }
            throw new Exception("Trying to initialize Driver more than once!");
        }

        public static void Utilize()
        {
            _driver = null;
        }
    }
}