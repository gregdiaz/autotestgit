using OpenQA.Selenium;


namespace Trademark.pageObjects
{
    class Dashboard
    {
        private IWebDriver driver;
        public string _stories = "news-stories-widget";
        public string _identifiers = "IdentifierQuantityChartWidget";
        public string _yearbtn = ".year.active";
        public string _events = "IdentifierEventQuantityChartWidget";
        public string _topevents = "TopEventsWidget";
        public string _summary = "IdentifierEventSummaryChartWidget";
        public string _myday = "myDayWidget";
        public string _sales = "RoyaltySalesByCategoryWidget";
        public string _royalytextbox = "#royaltiesAndSalesWidgetForm > div > div";
        public string _toproyalty = "TopRoyaltyOrganizations";
        public string _Toproyaltybtn = "#TopRoyaltyOrganizations > div > div.header > div";
        public string _salesroyalty = "SalesAndRoyaltyTrendOverTimeWidget";
        public string _menudrawer = "#leftnavigation";
        public string _logo = ".navbar-header > a > img";


        public Dashboard(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Newstorieswidget()
        {
            driver.FindElement(By.Id(_stories));
        }
        public void IdentifiersWidget()
        {

            driver.FindElement(By.Id(_identifiers));
        }

        public void EventsWidget()
        {
            driver.FindElement(By.Id(_events));
        }

        public void TopEventsWidget()
        {
            driver.FindElement(By.Id(_topevents));
        }
        public void EventSummaryWidget()
        {
            driver.FindElement(By.Id(_summary));

        }
        public void MyDayWidget() {
            driver.FindElement(By.Id(_myday));

        }

        public void SalesRoyaltyWidget() {

            driver.FindElement(By.Id(_sales));
            for (int i = 1; i < 3; i++)
            {
                var royaltyselector = _royalytextbox + ":nth-child("+ i +") > div";
                driver.FindElement(By.CssSelector(royaltyselector)); 
            }

        }

        public void TopRoyaltyWidget() {

            driver.FindElement(By.Id(_toproyalty));
            driver.FindElement(By.CssSelector(_Toproyaltybtn));
        }

        public void SalesRoyaltyTrendWidget()
        {      
            driver.FindElement(By.Id(_salesroyalty));
        }
        public void Menu_Nav() {
            driver.FindElement(By.CssSelector(_logo));                               
        }
        public IWebElement  Drawer_Menu() {
            driver.FindElement(By.CssSelector(_menudrawer));
            var element = driver.FindElement(By.CssSelector(_menudrawer));
            element.GetCssValue("innerHTML");
            return element;
        }
    }
}