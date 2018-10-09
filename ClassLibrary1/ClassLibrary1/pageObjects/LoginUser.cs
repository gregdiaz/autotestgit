using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Trademark.Common;

namespace Trademark.pageObjects
{
    class LoginUser
    {
        private IWebDriver driver;
        
        public string _email = "email";
        public string _pass = "password";
        public string _loginbtn = ".auth0-label-submit";
        public string _errorMenssage = "div.auth0-global-message-error span.animated > span";


        public LoginUser(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void opsecemail() {
            Thread.Sleep(5000);
            var user = ConfigurationManager.AppSettings["user"];
            driver.FindElement(By.Name(_email)).SendKeys(user);
        }

        public void opscpass() {
            var password = ConfigurationManager.AppSettings["pass"];
            driver.FindElement(By.Name(_pass)).SendKeys(password);
            clickbtn();
        }

        public void TypeWrongPass() {
            var pass_wrong = ConfigurationManager.AppSettings["pass_wrong"];
            driver.FindElement(By.Name(_pass)).SendKeys(pass_wrong);
            clickbtn();
        }

        public void clickbtn() {
           var loginbtn  = driver.FindElement(By.CssSelector(_loginbtn));
           loginbtn.Click();
        }

        public string GetMessageError()
        {
            Thread.Sleep(3000);
            return driver.FindElement(By.CssSelector(_errorMenssage)).Text;
        }
    }
}
