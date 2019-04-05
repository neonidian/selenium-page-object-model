namespace Framework {

using System;
using OpenQA.Selenium;

    public class LocatorObject {
        String objectValue;
        public String locatorDescription;
        public By locatorValue;
        public const String ID = "ID";
        public const String CSS = "CSS";
        public const String XPATH = "XPATH";
        public const String LINK_TEXT = "LINKTEXT";
        public const String PARTIAL_LINK_TEXT = "PARTIALLINKTEXT";
        public const String CLASS = "CLASS";
        public const String NAME = "NAME";
        String strLocatorType;

        public LocatorObject(String locator, String LocatorDescription, String locatorType) {
            this.objectValue = locator;
            this.locatorValue = GetLocatorObject(objectValue, locatorType);
            this.locatorDescription = LocatorDescription;
            strLocatorType = locatorType;
        }

        By GetLocatorObject(String locator, String locatorType) {
            switch (locatorType.ToUpper()) {
                case ID:
                    locatorValue = By.Id(locator);
                    break;
                case CSS:
                    locatorValue = By.CssSelector(locator);
                    break;
                case XPATH:
                    locatorValue = By.XPath(locator);
                    break;
                case LINK_TEXT:
                    locatorValue = By.LinkText(locator);
                    break;
                case CLASS:
                    locatorValue = By.ClassName(locator);
                    break;
                case NAME:
                    locatorValue = By.Name(locator);
                    break;
                case PARTIAL_LINK_TEXT:
                    locatorValue = By.PartialLinkText(locator);
                    break;
            }
            return locatorValue;
        }

        public LocatorObject Replace(String replacementText){
            return new LocatorObject
                    (this.objectValue.Replace("[*]", replacementText), this.locatorDescription, this.strLocatorType);
        }

        public LocatorObject Replace(String textToBeReplaced, String replacementText){
            return new LocatorObject(this.objectValue.Replace(textToBeReplaced, replacementText),
                    this.locatorDescription, this.strLocatorType);
        }

        public LocatorObject Replace(int replacementNumber){
            return new LocatorObject(this.objectValue.Replace("[*]", Convert.ToString(replacementNumber)),
                    this.locatorDescription, this.strLocatorType);
        }
    }
}