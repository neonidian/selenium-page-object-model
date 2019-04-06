namespace Framework {
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;

    public class BrowserFactory{
        private const string FIREFOX = "firefox";
        IWebDriver iWebDriver;

        public IWebDriver IWebDriver { get => iWebDriver; set => iWebDriver = value; }

        public IWebDriver InitializeBrowser(string browser)
        {
            switch (browser) {
                case FIREFOX: {
                    IWebDriver = new FirefoxDriver(new BrowserOptions().FirefoxDriverServiceGet, new BrowserOptions().FirefoxOptionsGet);
                    break;
                }
                default: {
                    Console.WriteLine("Browser value specified - '" + browser + "' does not match the supported browsers in this project");
                    Environment.ExitCode = -1;
                    break;
                }
            }
            IWebDriver.Manage().Window.Maximize(); 
            return IWebDriver;
        }

        public void CloseBrowser(IWebDriver iWebDriver) => iWebDriver.Quit();
    }
    
}