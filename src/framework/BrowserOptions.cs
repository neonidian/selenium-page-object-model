namespace Framework
{
    using OpenQA.Selenium.Firefox;
    public class BrowserOptions {
        public FirefoxDriverService FirefoxDriverService
        {
            get
            {
                FirefoxDriverService firefoxDriverService =
                    FirefoxDriverService.CreateDefaultService(@".");
                return firefoxDriverService;
            }
        }

        public FirefoxOptions FirefoxOptions
        {
            get
            {
                FirefoxOptions firefoxOptions = new FirefoxOptions();
                firefoxOptions.AcceptInsecureCertificates = true;
                firefoxOptions.LogLevel = FirefoxDriverLogLevel.Fatal;
                return firefoxOptions;
            }
        }
    }
}