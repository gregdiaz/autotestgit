using NUnit.Framework;
using Trademark.pageObjects;
using Trademark.Common;
using System.Threading;

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
            LoginUser login = new LoginUser(browser);
            login.opsecemail();
            login.TypeWrongPass();
            Assert.AreEqual(login.GetMessageError(), "WRONG EMAIL OR PASSWORD.");
        }
        
        [Test, Order(2)]
        public void Opseclogin_Sucessfull()
        {
            LoginUser login = new LoginUser(browser);
            browser.ClearText(login._pass);
            login.opscpass();
            Thread.Sleep(3000);
            browser.close();
        }


          
               
    }
}
