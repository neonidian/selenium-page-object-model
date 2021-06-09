namespace UITests
{
    using NUnit.Framework;

    [TestFixture]
    public class HomePageTests : TestBase 
    {

        [TestCase]
        public void VerifyNavigationToProductsPage() => Pages
                .HomePage                
                    .OpenHomePageUrl("https://www.axiomatics.com")
                    .GoToApplicationsPageByDynamicAuthorizationSuiteHeaderLink()                
                .ProductsPage                
                    .VerifyApplicationsProductPageDisplayed();
    }
}
