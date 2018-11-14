using NUnit.Framework;
using Trademark.pageObjects;
using Trademark.Common;
using System.Threading;

namespace Trademark.Test
{

    [TestFixture, Order(2)]
    class DashboardTest
    {
        Browser browser = new Browser();
        [Test, Order(1)]
        public void widgetelemets()
        {
            browser.SetUp();
            LoginUser login = new LoginUser(browser);
            login.opsecemail();
            login.opscpass();
            Thread.Sleep(3000);
            Dashboard homepage = new Dashboard(browser.driver);
            homepage.Newstorieswidget();
            homepage.IdentifiersWidget();
            homepage.EventsWidget();
            homepage.TopEventsWidget();
            homepage.EventSummaryWidget();
            homepage.MyDayWidget();
            homepage.SalesRoyaltyWidget();
            homepage.TopRoyaltyWidget();
            homepage.SalesRoyaltyTrendWidget();
            browser.close();
        }
    }
}
