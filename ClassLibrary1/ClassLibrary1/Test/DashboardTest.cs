using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Trademark.pageObjects;
using Trademark.Common;

namespace Trademark.Test
{

    [TestFixture, Order(2)]
    class DashboardTest
    {
        [Test, Order (1)]
        public void widgetelemets() {
            Browser browser = new Browser();
            browser.SetUp();
            LoginUser login = new LoginUser(browser.driver);
            login.opsecemail();
            login.opscpass();
            Dashboard homepage = new Dashboard(browser.driver);
            homepage.newstories();
        }
      


    }
}
