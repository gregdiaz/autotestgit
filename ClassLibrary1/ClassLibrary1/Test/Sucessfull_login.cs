using NUnit.Framework;
using Trademark.pageObjects;
using Trademark.Common;
using System.Threading;

namespace Trademark.Test
{
   [TestFixture, Order (1)]
    class Sucessfull_login
    {
        private Browser browser;
        private LoginUser login;

        public Sucessfull_login()
        {
            browser = new Browser();
            login = new LoginUser(browser);
        }
                
        [Test, Order(1)]
        public void Opseclogin_Unsucessfull()
        {
            login.opsecemail();
            login.TypeWrongPass();
            Assert.AreEqual(browser.GetMessage(login._errorMenssage), "WRONG EMAIL OR PASSWORD.");
        }
        
        [Test, Order(2)]
        public void Opsec_Remember() {
            login.remember();
            Assert.AreEqual(browser.GetMessage(login._remembermsj), "WE'VE JUST SENT YOU AN EMAIL TO RESET YOUR PASSWORD.");
        }

        [Test, Order (3)]
        public void Opseclogin_Sucessfull()
        {
            browser.ClearText(login._pass);
            login.opscpass();
            Thread.Sleep(3000);
            browser.close();
        }
    }
}
