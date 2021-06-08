namespace UITests {
    using System;
    using NUnit.Framework;
    using Utilities;
    using Framework;
    using OpenQA.Selenium;
    using Pages;

    public class TestBase {
        private IWebDriver WebDriver { get; set; }

        private BrowserFactory BrowserFactory { get; set; }

        protected PageBase Pages { get; private set; }

        [SetUp]
        public void InitializeTestSetup() {
            String browser = new ReadProperties().BrowserName;
            this.BrowserFactory = new BrowserFactory();
            this.WebDriver = BrowserFactory.InitializeBrowser(browser);
            this.Pages = new PageBase(WebDriver); 
        }

        [TearDown]
        public void CloseBrowser() {
            BrowserFactory.CloseBrowser(WebDriver);
        }
    }
}
