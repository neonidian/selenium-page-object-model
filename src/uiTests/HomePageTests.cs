namespace UITests
{
    using NUnit.Framework;

    [TestFixture]
    public class HomePageTests : TestBase {

        [TestCase]
        public void VerifyNavigationToProductsPage() => Pages
                .HomePage                
                    .OpenHomePageURL("https://www.axiomatics.com")
                    .GoToApplicationsPageByDynamicAuthorizationSuiteHeaderLinkInHeader()                
                .ProductsPage                
                    .VerifyApplicationsProductPageDisplayed();
    }
}