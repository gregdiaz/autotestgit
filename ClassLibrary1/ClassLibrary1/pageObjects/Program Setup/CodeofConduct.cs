﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Trademark.Common;

namespace Trademark.pageObjects.Program_Setup
{
    class CodeofConduct
    {
        private Browser browser;

        Menudrawer menudrawer = new Menudrawer();

        public CodeofConduct(Browser browser)
        {
            this.browser = browser;
            //LoginConection loginc = new LoginConection();
            
        }

        public string _codeconductab = "#codeOfConductTab";
        public string _search = "#searchConductCodes";
        public string _addcodeconduct = "#TopBarContainer > div:nth-child(2) > ol > li > a";
        public string _editbuton = "tr:nth-child(1) > td.text-center > ol > li:nth-child(1)";
        public string _nofoundinfo = "#ConductCodeTable > tbody > tr > td";
        public string _namedition = ".form-group:nth-child(2)>div>#name";
        public string _descriptionedit = ".form-group:nth-child(3) > div > #description";
        public string _disablebtn = "#conductCodeForm > div > div > div > div > div:nth-child(4) > div > div";
        public string _enableeditbtn = ".padding-bottom-10.form-inline > a:nth-child(1)";
        public string _noteeditable = ".note-editable.panel-body";
        public IWebElement x;
            
        public void CodeofConductinfo()
        {
           // LoginUser login = new LoginUser(browser);

            browser.Waitfor(10000);


            browser.GetElementBySelector(menudrawer._menudrawer).Click();
            browser.GetElementBySelector(menudrawer._menudrawerprogram).Click();
            browser.Waitfor(4000);
            browser.GetElementBySelector(_codeconductab).Click();
            browser.Waitfor(3000);
            // browser.VisibleSelectorbyId(_search);
            Editbtn();



        }

        public void Editbtn() {
            browser.GetElementBySelector(_addcodeconduct).Click();
            browser.GetElementBySelector(_namedition).SendKeys("This is an Autotest Code Conduct");
            browser.GetElementBySelector(_descriptionedit).SendKeys("Description Code Conduct");
            browser.GetElementBySelector(_enableeditbtn).Click();
            browser.GetElementBySelector(_noteeditable).SendKeys("Note on Code of Conducts");

                                 
//# conductCodeForm > div > div > div > div > div:nth-child(4) > div > .toggle btn btn-sm ios btn-default off

            //toggle btn btn - sm ios btn-primary
                                   
        }
        public IWebElement disablebotton() {
            x = browser.GetElementBySelector(_disablebtn);
            return x;
        }
    }
}
