using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using HandsOnSelenium.Base;
using HandsOnSelenium.Pages;

namespace HandsOnSelenium
{
    public class PirmasTestas : TestBase
    {
        private LoginPage loginPage;

        [SetUp]
        public void Setup()
        {
            loginPage = new LoginPage(driver);
        }

        [Test]
        public void OpenGoogle()
        {
            // Logstick Dalis

            loginPage.OrganizacijaInput
                .SendKeys("Visma");
            loginPage.OrganizacijaButton
                .Click();

            Thread.Sleep(1000);

            loginPage.singInToGoogleButton
                .Click();
            Thread.Sleep(2000);

            // Google Dalis
            
            var logstickNavBar = driver.FindElement(By.CssSelector(".navbar-brand"));
            Assert.AreEqual("LOGSTICK", logstickNavBar.Text, "Kazkoks kitas uzrasas buvo matomas");

        }
    }
}
