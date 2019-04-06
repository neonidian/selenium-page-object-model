namespace Pages {
    using System;
    using OpenQA.Selenium;
    using Framework;

    public class HomePage : PageBase {

        const String PAGE_NAME = "Home Page > ";
        readonly LocatorObject SearchMagnifyingGlassInput = new LocatorObject("input.button", PAGE_NAME + "Magnifying glass", LocatorObject.CSS);
        readonly LocatorObject SearchTextBox = new LocatorObject("inputBox.show", PAGE_NAME + "Magnifying glass > Search text box", LocatorObject.CSS);
        readonly LocatorObject DynamicAuthorizationHeaderLnk = new LocatorObject("a.dropdown-toggle.disabled[title=\"Dynamic Authorization Suite\"]", PAGE_NAME + "Header > Dynamic Authorization link", LocatorObject.CSS);
        readonly LocatorObject SubMenuOptionsInDynamicAuthorizationHeaderMenu = new LocatorObject("#menu-main-menu .dropdown-menu a[title=\"[*]\"]", PAGE_NAME + "Header > Dynamic Authorization Header menu > Sub menu dropdown", LocatorObject.CSS);

        public HomePage(IWebDriver iWebDriver) : base(iWebDriver) {}

        internal HomePage OpenHomePageURL(String URL) {
            seleniumActions.OpenURL(URL);
            return this;
       }

        internal HomePage Search(string keywordToSearch) {
            seleniumActions.HoverOnElementAndEnterText(SearchMagnifyingGlassInput, keywordToSearch);
            return this;
        }

        internal HomePage GoToApplicationsPageByDynamicAuthorizationSuiteHeaderLinkInHeader
        {
            get
            {
                seleniumActions.Click(DynamicAuthorizationHeaderLnk)
                    .Click(SubMenuOptionsInDynamicAuthorizationHeaderMenu.Replace("Applications"));
                return this;
            }
        }
    }
}