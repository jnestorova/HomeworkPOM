using AutoFixture;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AutomationPractice.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }

        protected Actions Builder { get; set; }


        public void Initialize()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Driver.Manage().Window.Maximize();
            Builder = new Actions(Driver);
        }

        public void CreateAccount()
        {
            var fixture = new Fixture();
            var mail = fixture.Create<string>() + "@gmail.com";
            var emailInput = Driver.FindElement(By.Id("email_create"));
            emailInput.SendKeys(mail);

            var createAccountButton = Driver.FindElement(By.Id(@"SubmitCreate"));
            var test = createAccountButton.Text;
            createAccountButton.Click();

            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            var emailText = wait.Until(ExpectedConditions.ElementExists(By.XPath("//form[@id='account-creation_form']//input[@id='email']")));
            var text = emailText.GetAttribute("value");
        }
    }
}
