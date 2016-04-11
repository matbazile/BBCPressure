using System;
using OpenQA.Selenium;
using WeatherBBC;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace AcceptanceTests
{

    public class BBCReadingPage
    {
        [FindsBy(How = How.Id, Using = "detail-table-view")]
        public IWebElement _tableLink;

       
        [FindsBy(How = How.XPath, Using = ".//*[@id='hourly']/div[3]/table/thead/tr/th[*]")]
        public IList<IWebElement> _todaysPressureList;

        [FindsBy(How = How.XPath, Using = ".//*[@id='hourly']/div[3]/table/tfoot/tr[3]/td[16]")]
        public IWebElement _tomorrow9PmPressure;

        [FindsBy(How = How.XPath, Using = ".//*[@id='blq-content']/div[7]/div[2]/ul/li[2]/a")]
        public IWebElement _tomorrowTab;

        public string GetTodays9pmPressure()
        {
            int columnNumber = 0; ;
           
            for (int i = 0; i < _todaysPressureList.Count; i++)
            {
                if (_todaysPressureList[i].Text.Contains("2100"))
                {
                    columnNumber = i+1;                    
                }
            }
           
            return Browser.Driver.FindElement(By.XPath(".//*[@id='hourly']/div[3]/table/tfoot/tr[3]/td[" + columnNumber + "]")).Text;
        }
    }
}