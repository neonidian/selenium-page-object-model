namespace UITests {
    using System;
    using NUnit.Framework;
    using Utilities;
    using Framework;
    using OpenQA.Selenium;
    using Pages;

    public class TestBase {
        BrowserFactory browserFactory;
        IWebDriver iWebDriver;
        public PageBase pages;

       [SetUp]
        public void InializeTestSetup() {
            String browser = new ReadProperties().BrowserName;
            this.browserFactory = new BrowserFactory();
            this.iWebDriver = browserFactory.InitializeBrowser(browser);
            this.pages = new PageBase(iWebDriver); 
        }

        [TearDown]
        public void CloseBrowser() {
            browserFactory.CloseBrowser(iWebDriver);
        }
    }
}