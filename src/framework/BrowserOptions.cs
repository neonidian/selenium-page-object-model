namespace Framework {

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
    public class BrowserOptions {
        public FirefoxDriverService FirefoxDriverServiceSet(){
            FirefoxDriverService firefoxDriverService = 
                FirefoxDriverService.CreateDefaultService(@"drivers/");
            return firefoxDriverService;
        }
    }
}