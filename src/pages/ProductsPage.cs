namespace Pages {
    using System;
    using OpenQA.Selenium;
    using Framework;

    public class ProductsPage : PageBase {

        const String PAGE_NAME = "Products Page > ";

        LocatorObject ProductPageHeadingLbl = new LocatorObject("h1.bigText", PAGE_NAME + "Products page heading label", LocatorObject.CSS);

        public ProductsPage(IWebDriver iWebDriver) : base(iWebDriver) {}

        internal ProductsPage VerifyApplicationsProductPageDisplayed() {
            seleniumActions.VerifyTextPresentInElement(ProductPageHeadingLbl, "Dynamic Authorization for Business Applications");
            return this;
        }
    }
}