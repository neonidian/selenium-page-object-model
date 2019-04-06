namespace Framework {
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;

    public class BrowserFactory{
        const string FIREFOX = "firefox";
        IWebDriver iWebDriver;

        public IWebDriver IWebDriver { get => iWebDriver; set => iWebDriver = value; }

        public IWebDriver InitializeBrowser(string browser)
        {
            switch (browser) {
                case FIREFOX: {
                    IWebDriver = new FirefoxDriver(new BrowserOptions().FirefoxDriverService, new BrowserOptions().FirefoxOptions);
                    break;
                }
                default: {
                    Console.WriteLine("Browser value specified - '" + browser + "' does not match the supported browsers in this project");
                    break;
                }
            }
            IWebDriver.Manage().Window.Maximize(); 
            return IWebDriver;
        }

        public void CloseBrowser(IWebDriver iWebDriver) => iWebDriver.Quit();
    }
    
}