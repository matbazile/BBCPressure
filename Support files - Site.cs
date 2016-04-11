using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using WeatherBBC;

namespace WeatherBBC
{
    public class Site
    {
        public static T Page <T>()
        {
            var page = Activator.CreateInstance<T>();
            PageFactory.InitElements(Browser.Driver, page);

            return page;
        }
    }
}