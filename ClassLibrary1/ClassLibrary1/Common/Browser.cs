using System;
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

        public Browser()
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

        public IWebElement GetElementById(string selector)
        {
            var wait = WaitMethod();
            IWebElement element = wait.Until(drv => drv.FindElement(By.Id(selector)));
            return element;
        }

        public IWebElement VisibleSelector(string selector) {
            IWebElement element = driver.FindElement(By.CssSelector(selector));
            return element;
        }

        public IWebElement VisibleSelectorbyId(string selector)
        {
            IWebElement element = driver.FindElement(By.Id(selector));
            return element;
        }

        public void RefreshPage()
        {
            driver.Navigate().Refresh();
        }

        public void clickelement(string selector)
        {
            var click = driver.FindElement(By.CssSelector(selector));
            click.Click();
        }

        public void ScrollToElement(string selector) {

            var element = driver.FindElement(By.CssSelector(selector));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        public WebDriverWait WaitMethod()
        {
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            return wait1;
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

        public string GetMessage(string selector)
        {
            Waitfor(5000);
            return driver.FindElement(By.CssSelector(selector)).Text;
        }

        public void close() {
            driver.Close();
        }
    }
}
