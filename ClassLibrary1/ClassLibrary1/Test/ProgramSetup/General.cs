using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Trademark.pageObjects;
using Trademark.Common;
using Trademark.pageObjects.Program_Setup;

namespace Trademark.Test
{
    [TestFixture, Order(1)]

    class Program_Setup_General
    {
        Browser browser = new Browser();
    

        [Test, Order (1)]
        public void General() {
            browser.SetUp();
            LoginUser login = new LoginUser(browser);
            login.opsecemail();
            login.opscpass();
            General program = new General(browser);
            program.general();
        }
        

    }
}
