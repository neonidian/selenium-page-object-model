namespace Framework {

    using OpenQA.Selenium;  
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
    using NUnit.Framework;
    using System;
    public class SeleniumActions {

        IWebDriver iWebDriver;
        IWebElement iWebElement;
        WebDriverWait webDriverWait;
        Actions actions;

        const Int32 explicitTimeOutInSeconds = 15;
        const Int32 implicitTimeOutInSeconds = 5;
        const Int32 pageLoadTimeOutInSeconds = 10;
        public SeleniumActions(IWebDriver iWebDriver){
            this.iWebDriver = iWebDriver;
            iWebDriver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromSeconds(pageLoadTimeOutInSeconds));
            iWebDriver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(implicitTimeOutInSeconds));
        }
        public SeleniumActions OpenURL(String URL){
            try {
                iWebDriver.Navigate().GoToUrl(URL);                
            }
            catch(WebDriverException webDriverException){
                Fail(webDriverException.Message);
            }
            return this;
        }

        public SeleniumActions HoverOnElement(LocatorObject locatorObject){
            try {
                WaitForElementToBeFound(locatorObject);
                actions = new Actions(iWebDriver);
                actions.MoveToElement(iWebDriver.FindElement(locatorObject.locatorValue)).Perform();
            }
            catch(WebDriverException webDriverException){
                Fail(webDriverException.Message);
            }
            return this;
        }

        public SeleniumActions HoverOnElementAndEnterText(LocatorObject locatorObject, String text){
            try {
                WaitForElementToBeFound(locatorObject);
                actions = new Actions(iWebDriver);
                actions.MoveToElement(iWebDriver.FindElement(locatorObject.locatorValue))
                        .SendKeys(text)
                        .SendKeys(Keys.Enter)
                        .Perform();
            }
            catch(WebDriverException webDriverException){
                Fail(webDriverException.Message);
            }
            return this;
        }

        public SeleniumActions Click(LocatorObject locatorObject){
            try {
                WaitForElementToBeFound(locatorObject);
                iWebDriver.FindElement(locatorObject.locatorValue).Click();
            }
            catch(WebDriverException webDriverException){
                Fail(webDriverException.Message);
            }
            return this;
        }

        public SeleniumActions EntTextInTextBox(LocatorObject locatorObject, String text){
            try {
                WaitForElementToBeFound(locatorObject);
                actions = new Actions(iWebDriver);
                actions.MoveToElement(iWebDriver.FindElement(locatorObject.locatorValue)).SendKeys(text).Perform();
            }
            catch(WebDriverException webDriverException){
                Fail(webDriverException.Message);
            }
            return this;
        }

        SeleniumActions WaitForElementToBeFound(LocatorObject locatorObject){
            try {
                webDriverWait = new WebDriverWait(iWebDriver, TimeSpan.FromSeconds(explicitTimeOutInSeconds));
                webDriverWait.Until(condition => condition.FindElements(locatorObject.locatorValue));
            }
            catch(WebDriverException webDriverException){
                Fail(webDriverException.Message);
            }
            return this;
        }

        public SeleniumActions VerifyTextPresentInElement(LocatorObject locatorObject, String textToVerify){
            try {
                WaitForElementToBeFound(locatorObject);
                String textFromElement = iWebDriver.FindElement(locatorObject.locatorValue).Text;
                if(!textFromElement.Contains(textToVerify)){
                    Fail("Text from element - '" + textFromElement + "' does not match expected text - '" + textToVerify + "'");
                }
            }
            catch(WebDriverException webDriverException){
                Fail(webDriverException.Message);
            }
            return this;
        }

        public void Fail(String failureMessage) {
            Assert.Fail(failureMessage);
        }
    }
}