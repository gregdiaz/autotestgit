using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trademark.Common;

namespace Trademark.pageObjects.Program_Setup
{
    class Organizationtag : General
    {
        private Browser browser;

        Menudrawer menudrawer = new Menudrawer();

        public Organizationtag (Browser browser) : base(browser)
        {
            this.browser = browser;
        }

        public string _useorganizationtab = "#organizationTagsTab";
        public string _search = "#TopBarContainer > div.col-sm-6 > div> #search-organization-tags";
        public string _addusertag = "#TopBarContainer > div.col-md-6 > ol > li > a";
        public string _paginatebtn = "#organization-tags-table_paginate";
        public string _namedition = "#organizationTagsForm > div > div > .form-group:nth-child(1) > div >#name";
        public string _inactivebtn = "#organizationTagsForm > div > div > div:nth-child(2) > div > div";
        public string _savebtn = "#organizationTagsForm > div > div > div.pull-right.margin-bottom-10 > button.btn.btn-primary.btnProcessRequest";
        public string _cancelbtn = "#organizationTagsForm > div > div > div.pull-right.margin-bottom-10 > button.btn.btn-success";


        public void Organizationtaginfo()
        {

            //browser.Waitfor(10000);
            general();

            // browser.GetElementBySelector(menudrawer._menudrawer).Click();
            // browser.GetElementBySelector(menudrawer._menudrawerprogram).Click();
            //browser.Waitfor(3000);
            browser.Waitfor(3000);
            browser.GetElementBySelector(_useorganizationtab).Click();
            browser.VisibleSelector(_search);
            browser.VisibleSelector(_paginatebtn);
            //Edituserttag();
                       
        }
        //the selectior of button is not working well there are seven selector equal

        public void Edituserttag()
        {

            browser.GetElementBySelector(_addusertag).Click();
            browser.GetElementBySelector(_namedition).SendKeys("This is an Autotest Organization Tag");
            browser.VisibleSelector(_inactivebtn).Click();
            browser.VisibleSelector(_savebtn);
            browser.VisibleSelector(_cancelbtn);
        }


    }
}
