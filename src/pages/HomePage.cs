namespace Pages 
{
    using Framework;
    using OpenQA.Selenium;
    
    public class HomePage : PageBase 
    {
        private const string PageName = "Home Page > ";
        private readonly LocatorObject _searchMagnifyingGlassInput = new LocatorObject("input.button", PageName + "Magnifying glass", LocatorObject.CSS);
        private readonly LocatorObject _searchTextBox = new LocatorObject("inputBox.show", PageName + "Magnifying glass > Search text box", LocatorObject.CSS);
        private readonly LocatorObject _dynamicAuthorizationHeaderLnk = new LocatorObject("a.dropdown-toggle.disabled[title=\"Dynamic Authorization Suite\"]", PageName + "Header > Dynamic Authorization link", LocatorObject.CSS);
        private readonly LocatorObject _subMenuOptionsInDynamicAuthorizationHeaderMenu = new LocatorObject("#menu-main-menu .dropdown-menu a[title=\"[*]\"]", PageName + "Header > Dynamic Authorization Header menu > Sub menu dropdown", LocatorObject.CSS);

        public HomePage(IWebDriver iWebDriver) : base(iWebDriver)
        {
        }

        internal HomePage OpenHomePageUrl(string url) 
        {
            SeleniumActions.OpenUrl(url);
            return this;
        }

        internal HomePage Search(string keywordToSearch) 
        {
            SeleniumActions.HoverOnElementAndEnterText(_searchMagnifyingGlassInput, keywordToSearch);
            return this;
        }

        internal HomePage GoToApplicationsPageByDynamicAuthorizationSuiteHeaderLink() 
        {
            SeleniumActions.Click(_dynamicAuthorizationHeaderLnk)
                .Click(_subMenuOptionsInDynamicAuthorizationHeaderMenu.Replace("Applications"));
            return this;
        }
    }
}
