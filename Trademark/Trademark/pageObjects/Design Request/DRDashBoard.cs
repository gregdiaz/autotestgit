using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Trademark.Common;

namespace Trademark.pageObjects.Design_Request
{
    class DRDashBoard
    {
       // private IWebDriver driver;
        private Browser browser;
        Menudrawer menudrawer = new Menudrawer();

        public DRDashBoard(Browser Browser)
        {
            this.browser = Browser;
        }


        //Filters
        //#approvals-filters > div > div > label:nth-child(1)
         // #approvals-filters > div > div > label:nth-child(1):nth-child(2)

        public string _filterby = "#approvals-filters > div > div > label";
        public string _filterapproval = "#approvals-filters > div > div > label:nth-child(1)";
        public string _filterpapprovalchange = "#approvals-filters > div > div > label:nth-child(2)";
        public string _filterresubmit = "#approvals-filters > div > div > label:nth-child(3)";
        public string _filterpendingapproval = "#approvals-filters > div > div > label:nth-child(4)";
        public string _filterpsubmission = "#approvals-filters > div > div > label:nth-child(5)";
        public string _filterrejected = "#approvals-filters > div > div > label:nth-child(6)";
        public string _filterpmyapproval = "#approvals-filters > div > div > label:nth-child(7)";
        public string _filtermysubmission= "#approvals-filters > div > div > label:nth-child(8)";
        public string _filterflagged = "#approvals-filters > div > div > label:nth-child(9)";
        public string _filteroverdue= "#approvals-filters > div > div > label:nth-child(10)";
        public string _filteradminerror = "#approvals-filters > div > div > label:nth-child(12)";
        public string _piechart = "#highcharts-0 > svg > g.highcharts-series-group";
        public string _legend = "#highcharts-0 > svg > g.highcharts-legend";
        public string _fivestars = "#approvalsListContainer";
        public string _addremovecolumns = "#approvalsList_wrapper > div.dt-buttons";
        public string _searchbox = "#searchBoxApproval";
        public string _savesearchbtn = ".col-sm-3.col-lg-2 > .btn.btn-primary";
        public string _saveconfirm = "#saveSearchModalConfirmation > div > div > div.modal-footer > a.btn.btn-primary";
        public string _searchlist = ".selectSearchListContainer";
        public string _searchinput = "#searchInput";
        public string _modaldialog = "#saveSearchModalConfirmation > .modal-dialog > .modal-content";
        public string _modalinput = "searchSaveAs";
        public string _deletesearch = "#selectSearchItems > div > div:nth-child(2) > .searchIcon > i";

        public void designfilters()
        {
            for (int i = 1; i < 12; i++)
            {
                var _filterelement = _filterby + ":nth-child(" + i + ")";
                browser.GetElementBySelector(_filterelement);
            }

        }


        public void designrequestlist() {
            browser.GetElementBySelector(menudrawer._menudrawer).Click();
            browser.GetElementBySelector(menudrawer._menudrequest).Click();
            browser.Waitfor(15);
            
           /* browser.VisibleSelector(_filterapproval);
            browser.VisibleSelector(_filterpapprovalchange);
            browser.VisibleSelector(_filterresubmit);
            browser.VisibleSelector(_filterpendingapproval);
            browser.VisibleSelector(_filterpsubmission);
            browser.VisibleSelector(_filterrejected);
            browser.VisibleSelector(_filterpmyapproval);
            browser.VisibleSelector(_filtermysubmission);
            browser.VisibleSelector(_filterflagged);
            browser.VisibleSelector(_filteroverdue);
            browser.VisibleSelector(_filterresubmit);
            browser.VisibleSelector(_filteradminerror);*/
           // browser.VisibleSelector(_piechart);
          //  browser.VisibleSelector(_legend);
            browser.VisibleSelector(_fivestars);
            browser.VisibleSelector(_addremovecolumns);
            designfilters();
            seachprocess();
        }

        public void seachprocess() {
            browser.GetElementBySelector(_searchbox).SendKeys("Automation");
            browser.GetElementBySelector(_savesearchbtn).Click();
            browser.VisibleSelector(_modaldialog);
            browser.GetElementByName(_modalinput).SendKeys("Save Automation");
            browser.GetElementBySelector(_saveconfirm).Click();
           // browser.GetElementBySelector(_searchlist).Click();
            browser.GetElementBySelector(_searchlist).Click();
             browser.GetElementById(_searchinput).SendKeys("Save Automation");
            browser.GetElementBySelector(_deletesearch).Click();
        }

  
    }
}
