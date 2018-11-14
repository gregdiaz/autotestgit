using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Trademark.Common;

namespace Trademark.pageObjects.Program_Setup
{
    class General
    {
        IWebDriver driver;
        private Browser browser;

        public General(Browser browser)
        {
            this.driver = browser.driver;
            this.browser = browser;
        }


        public IWebElement  _programsetup => browser.GetElementBySelector("#leftnavigation > li.active > ul > li:nth-child(2)");
        public string _generaltab = "#generalTabContent > div:nth-child(1) > div:nth-child(1)";
        public string _month = "#defaultEndMonth";
        public string _agreementbtn = "#generalTabContent > div:nth-child(1) > div:nth-child(2) > div > div > div.form-group.col-sm-2 > div > div > div > label.btn.btn-default.btn-sm.active.toggle-off";
        public string _approvalsbtn = "div:nth-child(3) > div > div > div > div > div > div > label.btn.btn-primary.btn-sm.toggle-on";
        public string _license_mgmt = "#licensemgmtLeftNavigationItem";
        public string _program = "#leftnavigation > li.active > ul > li.active";

        public void general() {
            browser.GetElementByName(_generaltab);
            browser.VisibleSelector(_month).Click();
            browser.GetElementBySelector(_agreementbtn);
            browser.GetElementBySelector(_approvalsbtn);
            browser.GetElementBySelector(_license_mgmt).Click();
            browser.GetElementBySelector(_program).Click();
        }


    }
}
