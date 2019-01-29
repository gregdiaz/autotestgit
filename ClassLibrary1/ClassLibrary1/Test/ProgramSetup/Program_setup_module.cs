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
        private Browser browser;
        private LoginUser login;

        public Program_Setup_General()
        {
            browser = new Browser();
            login = new LoginUser(browser);
        }

        [Test, Order(1)]
        public void General()
        {
            General program = new General(browser);
            login.opsecemail();
            login.opscpass();
           // browser.Waitfor(5000);
            program.general();
         //   browser.close();
            
        }

        [Test, Order(2)]
        public void CodeofConduct()
        {
            CodeofConduct conduct = new CodeofConduct(browser);
            login.opsecemail();
            login.opscpass();
            conduct.CodeofConductinfo();
            //Assert.AreEqual(conduct.disablebotton(),conduct._disablebtn);
            // pending tool on edit form 
            //cancel and save button on edit
            //table edit and disable
           
        }

        [Test, Order(3)]
        public void Usertags()
        {
            Usertags usertag = new Usertags(browser);
            login.opsecemail();
            login.opscpass();
            usertag.Usertaginfo();
        }

        [Test, Order(4)]
        public void Organizationtags()
        {
            Organizationtag organization = new Organizationtag(browser);
            login.opsecemail();
            login.opscpass();
            organization.Organizationtaginfo();
        }

        [Test, Order(5)]
        public void DesignSubmissionStagestag()
        {
            DSubmissionStages dsubmissionstage = new DSubmissionStages(browser);
            login.opsecemail();
            login.opscpass();
            dsubmissionstage.Dsubmissionstages();
        }

    }
}
