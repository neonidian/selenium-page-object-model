namespace UITests {
    using System;
    using System.Diagnostics;
    using NUnit.Framework;
    
   [TestFixture]
    public class HomePageTests : TestBase {
        
        [TestCase]
        public void VerifyNavigationToProductsPage() {
            pages
                .GetHomePage()
                .OpenHomePageURL("https://www.axiomatics.com")
                .GoToApplicationsPageByDynamicAuthorizationSuiteHeaderLinkInHeader()
                .GetProductsPage()
                .VerifyApplicationsProductPageDisplayed();
        }
    }
}