using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Configuration;
using Trademark.pageObjects;



namespace Trademark.Common

{
    class LoginConection
    {

        Browser browser = new Browser();
        
        public LoginConection()
        {
            LoginUser login = new LoginUser(browser);
            var user = ConfigurationManager.AppSettings["user"];
            browser.GetElementByName(login._email).SendKeys(user);
            var password = ConfigurationManager.AppSettings["pass"];
            browser.GetElementByName(login._pass).SendKeys(password);
        }
    }
}
