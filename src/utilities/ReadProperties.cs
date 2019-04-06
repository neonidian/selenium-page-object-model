namespace Utilities {
    using System;
    using System.IO;
    using Microsoft.Extensions.Configuration;
    public class ReadProperties {
        public String BrowserName;
        public ReadProperties() {
            ReadAppConfigProperties();
        }

        private void ReadAppConfigProperties() {
            string getCurrentPath = Directory.GetCurrentDirectory();
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddIniFile("SeleniumConfig.ini")
                .Build();    
            BrowserName = configurationBuilder.GetSection("Browser:BrowserName").Value;
        }
    }
}