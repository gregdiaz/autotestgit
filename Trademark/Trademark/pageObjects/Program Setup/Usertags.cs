using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trademark.Common;

namespace Trademark.pageObjects.Program_Setup
{
    class Usertags : General
    {
        private Browser browser;

        Menudrawer menudrawer = new Menudrawer();

        public Usertags(Browser browser) : base(browser)
        {
            this.browser = browser;
        }

       

        public string _usertagstab = "#userTagsTab";
        public string _serach = "searchUserTag";
        public string _addusertag = "#TopBarContainer > div.col-md-6 > ol > li > a";
        public string _paginatebtn = "#userTagsTable_paginate";
        public string _namedition = "#userTagForm > div > div > .form-group:nth-child(1) > div >#name";
        public string _tagtype = "#userTagForm > div > div > div:nth-child(2) > div > select";
        public string _inactivebtn = "#userTagForm > div > div > div:nth-child(3) > div > div";
        public string _savebtn = "#userTagForm > div > div > div.pull-right.margin-bottom-10 > button.btn.btn-primary.btnProcessRequest";
        public string _cancelbtn = "#userTagForm > div > div > div.pull-right.margin-bottom-10 > button.btn.btn-success";


        public void Usertaginfo()
        {

            general();

           // browser.WaitUntilElementVisible(menudrawer._menudrawer);


           // browser.GetElementBySelector(menudrawer._menudrawer).Click();
           // browser.GetElementBySelector(menudrawer._menudrawerprogram).Click();
            browser.Waitfor(4000);
            browser.GetElementBySelector(_usertagstab).Click();
            browser.Waitfor(3000);
            // browser.VisibleSelectorbyId(_search);
            //Edituserttag();



        }
        //the selectior of button is not working well there are seven selector equal

        public void Edituserttag() {

            browser.GetElementBySelector(_addusertag).Click();
            browser.GetElementBySelector(_namedition).SendKeys("This is an Autotest Code Conduct");
            browser.GetElementBySelector(_tagtype).Click();
            browser.VisibleSelector(_inactivebtn).Click();
            browser.VisibleSelector(_savebtn);
            browser.VisibleSelector(_cancelbtn);
        }


    }


}
