using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using Trademark.pageObjects;
using Trademark.Common;

namespace Trademark.Test
{

    [TestFixture, Order (1)]
    class Sucessfull_login
    {
        Browser browser = new Browser();
        [Test, Order(1)]
        public void Opseclogin_Unsucessfull()
        {
            //Browser browser = new Browser();
            browser.SetUp();
            LoginUser login = new LoginUser(browser.driver);
            login.opsecemail();
            login.TypeWrongPass();
            Assert.AreEqual(login.GetMessageError(), "WRONG EMAIL OR PASSWORD.");
        }
        
        [Test, Order(2)]
        public void Opseclogin_Sucessfull()
        {
            LoginUser login = new LoginUser(browser.driver);
            browser.ClearText(login._email);
            browser.ClearText(login._pass);
            login.opsecemail();
            login.opscpass();
            browser.close();
        }


          
               
    }
}
