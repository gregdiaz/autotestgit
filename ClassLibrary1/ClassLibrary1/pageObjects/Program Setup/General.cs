using Trademark.Common;

namespace Trademark.pageObjects.Program_Setup
{
    class General
    {
        private Browser browser;

        Menudrawer menudrawer = new Menudrawer();

        public General(Browser browser)
        {
            this.browser = browser;
        }

        public string _generaltab = "#generalTabContent > div:nth-child(1) > div:nth-child(1)";
        public string _month = "#defaultEndMonth";
        public string _agreementbtn = "#generalTabContent > div:nth-child(1) > div:nth-child(2) > div > div > div.form-group.col-sm-2 > div > div > div > label.btn.btn-default.btn-sm.active.toggle-off";
        public string _approvalsbtn = "div:nth-child(3) > div > div > div > div > div > div > label.btn.btn-primary.btn-sm.toggle-on";
        public string _program = "#leftnavigation > li.active > ul > li.active";

       
        public void general() {

            browser.Waitfor(20000);
            browser.GetElementBySelector(menudrawer._menudrawer).Click();
            browser.GetElementBySelector(menudrawer._menudrawerprogram).Click();
            browser.Waitfor(2000);
            browser.GetElementBySelector(_generaltab);
            browser.VisibleSelector(_month);
            browser.GetElementBySelector(_agreementbtn);
            browser.GetElementBySelector(_approvalsbtn);
            browser.GetElementBySelector(_program).Click();
          }


    }
}
