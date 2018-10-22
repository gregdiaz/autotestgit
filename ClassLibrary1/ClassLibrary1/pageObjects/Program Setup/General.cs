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

        public General()
        {
            this.driver = browser.driver;
            //this.browser = browser;
        }


        public IWebElement _programsetup => browser.GetElementBySelector("#leftnavigation > li.active > ul > li:nth-child(2)");
        public string _generaltab => "#generalTabContent > div:nth-child(1) > div:nth-child(1)";


        public void general() {


        }
                     

    }
}
