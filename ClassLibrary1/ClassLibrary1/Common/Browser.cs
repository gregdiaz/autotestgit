using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace Trademark.Common
{
    class Browser
    {
       public IWebDriver driver { get; private set;}
         
        public void SetUp()
        {
           driver = new ChromeDriver();
           driver.Manage().Window.Maximize();
           var url = ConfigurationManager.AppSettings["url"];
           driver.Navigate().GoToUrl(url);
        }

        public void GetElementByName(string Selector)
        {
           driver.FindElement(By.Name(Selector));
        }

        public void waitMethod() {
            var timeout = 10;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
        }

        public void close() {
            driver.Close();
        }



    }
}
