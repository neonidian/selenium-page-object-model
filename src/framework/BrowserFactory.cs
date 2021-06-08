namespace Framework {
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;

    public class BrowserFactory{
        private const string Firefox = "firefox";
        IWebDriver _iWebDriver;

        private IWebDriver IWebDriver { get => _iWebDriver; set => _iWebDriver = value; }

        public IWebDriver InitializeBrowser(string browser)
        {
            switch (browser) {
                case Firefox: {
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

        public static void CloseBrowser(IWebDriver iWebDriver) => iWebDriver.Quit();
    }
}
