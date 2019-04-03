namespace Pages {
    using System;
    using OpenQA.Selenium;
    using Framework;

    public class HomePage : PageBase {

        const String PAGE_NAME = "Home Page > ";

        LocatorObject SearchMagnifyingGlassInput = new LocatorObject("input.button", PAGE_NAME + "Magnifying glass", LocatorObject.CSS);
        LocatorObject SearchTextBox = new LocatorObject("inputBox.show", PAGE_NAME + "Magnifying glass > Search text box", LocatorObject.CSS);
        LocatorObject DynamicAuthorizationHeaderLnk = new LocatorObject("a.dropdown-toggle.disabled", PAGE_NAME + "Header > Dynamic Authorization link", LocatorObject.CSS);

        public HomePage(IWebDriver iWebDriver) : base(iWebDriver) {}

        internal HomePage OpenHomePageURL(String URL) {
           seleniumActions.OpenURL(URL);
           return this;
       }

        internal HomePage Search(string keywordToSearch) {
            seleniumActions.HoverOnElementAndEnterText(SearchMagnifyingGlassInput, keywordToSearch);
            return this;
        }

        internal HomePage GoToProductsAndServicesPageByDynamicAuthorizationSuiteHeaderLinkInHeader() {
            // Two clicks required on 'Dynamic Authorization Suite' header link
            // 1st click opens up a list of products in the same page
            // 2nd click navigates to Products & Services page
            seleniumActions.Click(DynamicAuthorizationHeaderLnk);
            seleniumActions.Click(DynamicAuthorizationHeaderLnk);
            return this;
        }

    }
}