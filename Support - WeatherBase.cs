using WeatherBBC;
using OpenQA.Selenium;
using System.Collections;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Remote;

namespace AcceptanceTests
{
    
    public class WeatherBase
    {
        [BeforeScenario]
        public void Init()
        {
            if (Browser.Driver == null || ((RemoteWebDriver)Browser.Driver).SessionId== null)
            {
                Browser.Initialized();
                Browser.Driver.Navigate().GoToUrl("http://www.bbc.co.uk/weather");
                Browser.Driver.FindElement(By.XPath(".//*[@id='bbccookies-continue-button']")).Click();
            }
        }

        [AfterScenario]
        public void Close()
        {
            Browser.Driver.Close();
        } 
    }
}