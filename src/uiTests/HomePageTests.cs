namespace UITests
{
    using NUnit.Framework;

    [TestFixture]
    public class HomePageTests : TestBase {

        [TestCase]
        public void VerifyNavigationToProductsPage() => Pages
                .GetHomePage()
                .OpenHomePageURL("https://www.axiomatics.com")
                .GoToApplicationsPageByDynamicAuthorizationSuiteHeaderLinkInHeader                .GetProductsPage()
                .VerifyApplicationsProductPageDisplayed();
    }
}