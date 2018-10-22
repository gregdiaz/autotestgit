using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;

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

        public IWebElement GetElementByName(string selector)
        {
            var wait = WaitMethod();
            IWebElement element = wait.Until(drv => drv.FindElement(By.Name(selector)));
            return element;
        }

        public IWebElement GetElementBySelector(string selector)
        {
            var wait = WaitMethod();
            IWebElement element = wait.Until(drv => drv.FindElement(By.CssSelector(selector)));
            return element;
        }

        public void RefreshPage()
        {
            driver.Navigate().Refresh();
        }

        public void ScrollToElement(string selector) {

            var element = driver.FindElement(By.CssSelector(selector));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        public WebDriverWait WaitMethod()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait;
        }

        public void ClearText(string Selector)
        {
            var wait = WaitMethod();
            IWebElement element = wait.Until(drv => drv.FindElement(By.Name(Selector)));
            element.Clear();
        }
        public void Waitfor(int seg) {
            Thread.Sleep(seg);
        }

        public void close() {
            driver.Close();
        }



    }
}
