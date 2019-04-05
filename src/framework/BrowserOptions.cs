namespace Framework {

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
    public class BrowserOptions {
        public FirefoxDriverService FirefoxDriverServiceGet(){
            FirefoxDriverService firefoxDriverService = 
                FirefoxDriverService.CreateDefaultService(@"drivers/");
            return firefoxDriverService;
        }

        public FirefoxOptions FirefoxOptionsGet(){
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            firefoxOptions.AcceptInsecureCertificates = true;
            firefoxOptions.LogLevel = FirefoxDriverLogLevel.Fatal;
            return firefoxOptions;
        }
    }
}