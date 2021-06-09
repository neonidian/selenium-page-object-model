namespace Framework
{
    using System;
    using OpenQA.Selenium;

    public class LocatorObject
    {
        private readonly string _objectValue;
        public readonly string LocatorDescription;
        public const string ID = "ID";
        public const string CSS = "CSS";
        public const string XPATH = "XPATH";
        public const string LINK_TEXT = "LINKTEXT";
        public const string PARTIAL_LINK_TEXT = "PARTIALLINKTEXT";
        public const string CLASS = "CLASS";
        public const string NAME = "NAME";
        private readonly string _strLocatorType;

        public By LocatorValue
        {
            get; private set; 
        }

        public LocatorObject(String locator, String locatorDescription, String locatorType)
        {
            this._objectValue = locator;
            this.LocatorValue = GetLocatorObject(_objectValue, locatorType);
            this.LocatorDescription = locatorDescription;
            _strLocatorType = locatorType;
        }

        private By GetLocatorObject(String locator, String locatorType)
        {
            switch (locatorType.ToUpper())
            {
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
            (this._objectValue.Replace("[*]", replacementText), this.LocatorDescription, this._strLocatorType);

        public LocatorObject Replace(String textToBeReplaced, String replacementText) =>
            new(this._objectValue.Replace(textToBeReplaced, replacementText),
                this.LocatorDescription, this._strLocatorType);

        public LocatorObject Replace(int replacementNumber) => new LocatorObject(
            this._objectValue.Replace("[*]", Convert.ToString(replacementNumber)),
            this.LocatorDescription, this._strLocatorType);
    }
}
