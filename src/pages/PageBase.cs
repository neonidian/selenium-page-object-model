namespace Pages {
    using Framework;
    using OpenQA.Selenium;

    public class PageBase {
        IWebDriver iWebDriver;
        protected SeleniumActions seleniumActions;
        public PageBase(IWebDriver iWebDriver){
            this.iWebDriver = iWebDriver;            
            seleniumActions = new SeleniumActions(iWebDriver);
        }
        
        public HomePage GetHomePage(){
            HomePage homePage = new HomePage(iWebDriver);
            return homePage;
        }

        public ProductsPage GetProductsPage(){
            ProductsPage productsPage = new ProductsPage(iWebDriver);
            return productsPage;
        }
    }
}