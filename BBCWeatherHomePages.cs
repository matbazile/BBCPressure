using System;
using OpenQA.Selenium;
using WeatherBBC;
using OpenQA.Selenium.Support.PageObjects;

namespace AcceptanceTests

{
    public class BBCWeatherHomePage
    {
        [FindsBy(How = How.Id, Using = "locator-form-search")]
        public IWebElement _findAForecastBox;

        [FindsBy(How = How.Id, Using = "locator-ac-2639577")]
        public IWebElement _searchSuggestion;

        public BBCWeatherHomePage Visit()
        {
            Browser.Driver.Navigate().GoToUrl("http://www.bbc.co.uk/weather");
            
            return this;
        }
    }
}