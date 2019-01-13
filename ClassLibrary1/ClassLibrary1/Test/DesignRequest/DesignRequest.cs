using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Trademark.pageObjects;
using Trademark.Common;
using Trademark.pageObjects.Program_Setup;
using OpenQA.Selenium;
using Trademark.pageObjects.Design_Request;

namespace Trademark.Test
{
    [TestFixture, Order(4)]

    class DesignRequest
    {
        Browser browser = new Browser();
//Menudrawer menudrawer = new Menudrawer();

        [Test, Order(1)]
        public void DesignRequestList()  {
            LoginUser login = new LoginUser(browser);
            DRDashBoard designlist = new DRDashBoard(browser);
            login.opsecemail();
            login.opscpass();
            // menudrawer._menudrawer.Click();
            //menudrawer._menudesignrequest.Click();
            browser.Waitfor(20);
            designlist.designrequestlist();
            browser.close();
        }
    }
}