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
            LoginUser login = new LoginUser(browser);
            login.opsecemail();
            login.TypeWrongPass();
            Assert.AreEqual(browser.GetMessage(login._errorMenssage), "WRONG EMAIL OR PASSWORD.");
        }
        
        [Test, Order(2)]
        public void Opsec_Remember() {
            LoginUser login = new LoginUser(browser);
            login.remember();
            Assert.AreEqual(browser.GetMessage(login._remembermsj), "WE'VE JUST SENT YOU AN EMAIL TO RESET YOUR PASSWORD.");
        }

        [Test, Order (3)]
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
