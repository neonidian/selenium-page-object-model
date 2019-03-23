namespace Pages {
    using System;
    using OpenQA.Selenium;
    using Framework;

    public class ProductsPage : PageBase {

        const String PAGE_NAME = "Products Page > ";

        LocatorObject ProductsAndServicesHeadingLbl = new LocatorObject("h1.bigText", PAGE_NAME + "Products page heading label", LocatorObject.CSS);

        public ProductsPage(IWebDriver iWebDriver) : base(iWebDriver) {}

        internal ProductsPage VerifyProductsPageDisplayed() {
            seleniumActions.VerifyTextPresentInElement(ProductsAndServicesHeadingLbl, "Products & Services");
            return this;
        }
    }
}