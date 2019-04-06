namespace Framework {

using System;
using OpenQA.Selenium;

    public class LocatorObject {
        readonly String objectValue;
        public String locatorDescription;
        By locatorValue;
        public const String ID = "ID";
        public const String CSS = "CSS";
        public const String XPATH = "XPATH";
        public const String LINK_TEXT = "LINKTEXT";
        public const String PARTIAL_LINK_TEXT = "PARTIALLINKTEXT";
        public const String CLASS = "CLASS";
        public const String NAME = "NAME";
        readonly String strLocatorType;

        public By LocatorValue { get => locatorValue; set => locatorValue = value; }

        public LocatorObject(String locator, String LocatorDescription, String locatorType) {
            this.objectValue = locator;
            this.LocatorValue = GetLocatorObject(objectValue, locatorType);
            this.locatorDescription = LocatorDescription;
            strLocatorType = locatorType;
        }

        By GetLocatorObject(String locator, String locatorType) {
            switch (locatorType.ToUpper()) {
                case ID:
                    LocatorValue = By.Id(locator);
                    break;
                case CSS:
                    LocatorValue = By.CssSelector(locator);
                    break;
                case XPATH:
                    LocatorValue = By.XPath(locator);
                    break;
                case LINK_TEXT:
                    LocatorValue = By.LinkText(locator);
                    break;
                case CLASS:
                    LocatorValue = By.ClassName(locator);
                    break;
                case NAME:
                    LocatorValue = By.Name(locator);
                    break;
                case PARTIAL_LINK_TEXT:
                    LocatorValue = By.PartialLinkText(locator);
                    break;
            }
            return LocatorValue;
        }

        public LocatorObject Replace(String replacementText) => new LocatorObject
                    (this.objectValue.Replace("[*]", replacementText), this.locatorDescription, this.strLocatorType);

        public LocatorObject Replace(String textToBeReplaced, String replacementText) => new LocatorObject(this.objectValue.Replace(textToBeReplaced, replacementText),
                    this.locatorDescription, this.strLocatorType);

        public LocatorObject Replace(int replacementNumber) => new LocatorObject(this.objectValue.Replace("[*]", Convert.ToString(replacementNumber)),
                    this.locatorDescription, this.strLocatorType);
    }
}