namespace Framework {
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;

    public class BrowserFactory{
        IWebDriver iWebDriver;
        public IWebDriver InitializeBrowser(string browser)
        {
            BrowserOptions browserOptions = new BrowserOptions();
            switch(browser) {
                case "firefox": {                    
                    iWebDriver = new FirefoxDriver(browserOptions.FirefoxDriverServiceGet(), browserOptions.FirefoxOptionsGet());
                    break;
                }
                default: {
                    Console.WriteLine("Browser value specified - '" + browser + "' does not match the supported browsers in this project");
                    Environment.ExitCode = -1;
                    break;
                }
            }
            iWebDriver.Manage().Window.Maximize(); 
            return iWebDriver;
        }

        public void CloseBrowser(IWebDriver iWebDriver){
            iWebDriver.Quit();
        }
    }
    
}