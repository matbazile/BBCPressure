using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WeatherBBC
{
    public class Browser
    {
        public static IWebDriver Driver { get;  private set; }

        public static void Initialized()
        {
            Driver = new FirefoxDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        public static void Close()
        {
            Driver.Close();
        }
    }
}