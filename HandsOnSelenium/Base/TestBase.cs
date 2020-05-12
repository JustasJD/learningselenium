using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace HandsOnSelenium.Base
{
    [TestFixture]
    public class TestBase
    {
        protected FirefoxDriver driver;

        [SetUp]
        public void CreateDriver()
        {
            FirefoxProfile fireFoxProfile = new FirefoxProfile(@"C:\Profile");
            FirefoxOptions fireFoxOptions = new FirefoxOptions();

            fireFoxProfile = new FirefoxProfile(@"C:\Profile");
            fireFoxOptions.Profile = fireFoxProfile;
            driver = new FirefoxDriver(fireFoxOptions);

            driver.Url = "https://logstick-visma-test.azurewebsites.net/";
        }

        [TearDown]
        public void QuitDriver()
        {
            if (driver != null)
                driver.Quit();
        }
    }
}
