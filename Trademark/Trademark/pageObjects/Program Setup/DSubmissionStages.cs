using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trademark.Common;
using OpenQA.Selenium;



namespace Trademark.pageObjects.Program_Setup
{
    class DSubmissionStages : General
    {
        private Browser browser;

        //Menudrawer menudrawer = new Menudrawer();

        public DSubmissionStages(Browser browser) : base(browser)
        {
            this.browser = browser;
        }



        public string _dsubmissiontag = "#SubmissionStagesTab";
        public string _searchsubmission = "#TopBarContainer > div:nth-child(1) > div > #searchSubmissionStages";
        public string _addsubmissionstage = "#TopBarContainer > div:nth-child(2) > ol > li > a";
        public string _pagination = "#SubmissionStageTable_paginate";
        public string _nameedition = "#SubmissionStageForm > div > div > div > div > div.form-group > div > #name";
        public string _savebtn = "#SubmissionStageForm > div > div > div > div > div.pull-right.margin-bottom-10 > button.btn.btn-primary.btnProcessRequest";
        public string _cancelbtn = "#SubmissionStageForm > div > div > div > div > div.pull-right.margin-bottom-10 > button.btn.btn-success";
        public string _tablerows = "#SubmissionStageTable > tbody > tr > td.sorting_1";
        public string _disablebtntable = "#SubmissionStageTable > tbody > tr:nth-child(1) > td.text-center > ol > li:nth-child(2) > a > i";


        public void Dsubmissionstages(){

            general();
            browser.GetElementBySelector(_dsubmissiontag).Click();
            browser.VisibleSelector(_searchsubmission);
            browser.VisibleSelector(_pagination);
            AddSubmissionStages();
        }

        public void AddSubmissionStages() {

            browser.GetElementBySelector(_addsubmissionstage).Click();
            browser.GetElementBySelector(_nameedition).SendKeys("New Design Submission Stage Automation Test");
            browser.VisibleSelector(_cancelbtn);
            browser.GetElementBySelector(_savebtn).Click();
            browser.Waitfor(3000);
            browser.GetElementBySelector(_searchsubmission).SendKeys("New Design Submission Stage Automation Test");

            try
            {
                browser.GetElementBySelector(_tablerows);
                var getdisable = browser.GetElementBySelector(_disablebtntable);
                getdisable.Click();
                var colordisable =  getdisable.GetCssValue("style");


            }
            catch(NoSuchElementException) {
                Console.Write("Not Found the search");
            };

            




        }

    }


}
