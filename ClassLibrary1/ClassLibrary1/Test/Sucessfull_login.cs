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

    [TestFixture]
    class Sucessfull_login
    {
        [Test]
        public void opseclogin_sucessfull()
        {
            Browser browser = new Browser();
            browser.SetUp();
            LoginUser login = new LoginUser(browser.driver);
            login.opsecemail();
            login.opscpass();
        }

       

        



    }
}
