using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Trademark.pageObjects
{
    class Dashboard
    {
        private IWebDriver driver;
        public string _stories = "news-stories-widget";
        public string _identifiers = "IdentifierQuantityChartWidget";
        public string _events = "IdentifierEventQuantityChartWidget";
        public string _topevents = "TopEventsWidget";
        public string _summary = "IdentifierEventSummaryChartWidget";
        public string _myday = "myDayWidget";
        public string _sales = "RoyaltySalesByCategoryWidget";
        public string _toproyalty = "TopRoyaltyOrganizations";
        public string _salesroyalty = "SalesAndRoyaltyTrendOverTimeWidget";

        public Dashboard(IWebDriver driver)
      {
            this.driver = driver; 
      }
        public void newstories()
        {
            driver.FindElement(By.Id(_stories));
        }

    }
}
