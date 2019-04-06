namespace Framework
{
    using OpenQA.Selenium.Firefox;
    public class BrowserOptions {
        public FirefoxDriverService FirefoxDriverServiceGet
        {
            get
            {
                FirefoxDriverService firefoxDriverService =
                    FirefoxDriverService.CreateDefaultService(@"drivers/");
                return firefoxDriverService;
            }
        }

        public FirefoxOptions FirefoxOptionsGet
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