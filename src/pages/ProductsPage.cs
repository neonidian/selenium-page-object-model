namespace Pages 
{
    using Framework;
    using OpenQA.Selenium;
    
    public class ProductsPage : PageBase 
    {
        private const string PageName = "Products Page > ";
        private readonly LocatorObject _productPageHeadingLbl = new LocatorObject("h1.bigText", PageName + "Products page heading label", LocatorObject.CSS);

        public ProductsPage(IWebDriver iWebDriver) : base(iWebDriver)
        {
        }

        internal ProductsPage VerifyApplicationsProductPageDisplayed() 
        {
            SeleniumActions.VerifyTextPresentInElement(_productPageHeadingLbl, "Dynamic Authorization for Business Applications");
            return this;
        }
    }
}
