namespace Pages 
{
    using Framework;
    using OpenQA.Selenium;

    public class PageBase 
    {
        private readonly IWebDriver _iWebDriver;
        protected readonly SeleniumActions SeleniumActions;
        
        public PageBase(IWebDriver iWebDriver)
        {
            _iWebDriver = iWebDriver;            
            SeleniumActions = new SeleniumActions(iWebDriver);
        }

        public HomePage HomePage
        {
            get
            {
                HomePage homePage = new HomePage(_iWebDriver);
                return homePage;
            }
        }

        public ProductsPage ProductsPage
        {
            get
            {
                ProductsPage productsPage = new ProductsPage(_iWebDriver);
                return productsPage;
            }
        }
    }
}
