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
        PageBase pages;

        public IWebDriver IWebDriver { get => iWebDriver; set => iWebDriver = value; }
        public BrowserFactory BrowserFactory { get => browserFactory; set => browserFactory = value; }
        public PageBase Pages { get => pages; set => pages = value; }

        [SetUp]
        public void InializeTestSetup() {
            String browser = new ReadProperties().BrowserName;
            this.BrowserFactory = new BrowserFactory();
            this.IWebDriver = BrowserFactory.InitializeBrowser(browser);
            this.Pages = new PageBase(IWebDriver); 
        }

        [TearDown]
        public void CloseBrowser() {
            BrowserFactory.CloseBrowser(IWebDriver);
        }
    }
}