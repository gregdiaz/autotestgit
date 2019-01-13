using System.Configuration;
using System.Threading;
using OpenQA.Selenium;
using Trademark.Common;

namespace Trademark.pageObjects
{
    class LoginUser
    {
        private IWebDriver driver;
        private Browser browser;
        
        public string _email = "email";
        public string _pass = "password";
        public string _loginbtn = ".auth0-label-submit";
        public string _errorMenssage = "div.auth0-global-message-error span.animated > span";
        public string _remember = ".auth0-lock-form> div > div > .auth0-lock-alternative";
        public string _remembermsj = "div > div:nth-child(2) > div > div > span > span";

        public LoginUser(Browser browser)
        {
            this.driver = browser.driver;
            this.browser = browser;
        }

        public void opsecemail() {
            browser.Waitfor(3000);
            var user = ConfigurationManager.AppSettings["user"];
            driver.FindElement(By.Name(_email)).SendKeys(user);
        }

        public void opscpass() {
            var password = ConfigurationManager.AppSettings["pass"];
            driver.FindElement(By.Name(_pass)).SendKeys(password);
            browser.clickelement(_loginbtn);
        }

        public void TypeWrongPass() {

            var pass_wrong = ConfigurationManager.AppSettings["pass_wrong"];
            browser.GetElementByName(_pass).SendKeys(pass_wrong);
            browser.clickelement(_loginbtn);
        }

        public void remember() {
            browser.Waitfor(3000);
            browser.clickelement(_remember);
            if (browser.GetElementByName(_email).GetAttribute("value") == string.Empty) {
                var user = ConfigurationManager.AppSettings["user"];
                opsecemail();
            }
            browser.clickelement(_loginbtn);
        }

    }
}
