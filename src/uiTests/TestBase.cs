namespace UITests 
{
    using NUnit.Framework;
    using Utilities;
    using Framework;
    using OpenQA.Selenium;
    using Pages;

    public class TestBase 
    {
        private IWebDriver WebDriver
        {
            get; set; 
        }

        private BrowserFactory BrowserFactory
        {
            get; set; 
        }

        protected PageBase Pages
        {
            get; private set;
        }

        [SetUp]
        public void InitializeTestSetup() 
        {
            string browser = new ReadProperties().BrowserName;
            BrowserFactory = new BrowserFactory();
            WebDriver = BrowserFactory.InitializeBrowser(browser);
            Pages = new PageBase(WebDriver); 
        }

        [TearDown]
        public void CloseBrowser() 
        {
            BrowserFactory.CloseBrowser(WebDriver);
        }
    }
}
