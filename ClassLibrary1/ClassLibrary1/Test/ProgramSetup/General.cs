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


namespace Trademark.Test
{
    [TestFixture, Order(3)]

    class Program_Setup_General
    {
        Browser browser = new Browser();
        // Menudrawer menudrawer = new Menudrawer();
        //public IWebElement _menudrawer => browser.GetElementBySelector("#leftnavigation > li.active > ul > li.active > a");

        [Test, Order(1)]
        public void General()
        {
            LoginUser login = new LoginUser(browser);

            General program = new General(browser);
            login.opsecemail();
            login.opscpass();
            browser.Waitfor(3000);
            program.general();
            browser.close();
            
        }

        [Test, Order(2)]
        public void CodeofConduct()
        {
            LoginUser login = new LoginUser(browser);
            login.opsecemail();
            login.opscpass();
            CodeofConduct conduct = new CodeofConduct(browser);
            conduct.CodeofConductinfo();
            Assert.AreEqual(conduct.disablebotton(),conduct._disablebtn);
                       
        }

        [Test, Order(3)]
        public void Usertags()
        {
            LoginUser login = new LoginUser(browser);
            login.opsecemail();
            login.opscpass();




        }
    }
}
