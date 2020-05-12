using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HandsOnSelenium.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement OrganizacijaInput => driver.FindElement(By.CssSelector(
            "body > ls-root > div.app-container > ng-component > div > div > div > div > form > input"));

        public IWebElement OrganizacijaButton => driver.FindElement(By.CssSelector(
            "body > ls-root > div.app-container > ng-component > div > div > div > div > form > button"));

        public IWebElement singInToGoogleButton => driver.FindElement(By.CssSelector(
            "body > ls-root > div.app-container > ng-component > div > div > div > div > form > a"));

        public void FillLoginInformation(string organizacija)
        {
            OrganizacijaInput.SendKeys(organizacija);
            Thread.Sleep(1000);
            OrganizacijaButton.Click();
            singInToGoogleButton.Click();
        }

    }
}
