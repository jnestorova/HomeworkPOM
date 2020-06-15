using ToolsQA.Tests;
using ToolsQA.Utilities.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ToolsQA.Tests
{
    public class NavigationTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]

        public void SuccessfullyPageLoaded_When_NavigateToSortable(string sectionName)
        {
            var interactions = Driver.FindElement(By.XPath("//*[normalize-space(text())='Interactions']/ancestor::div[contains(@class, 'top-card')]"));
            interactions.Click();

            var menuButton = Driver.FindElement(By.XPath($"//*[normalize-space(text())='{sectionName}']"));
            Driver.ScrollTo(menuButton);
            menuButton.Click();

            var pageHeader = Driver.FindElement(By.ClassName("main-header"));
            Assert.AreEqual(sectionName, pageHeader.Text);
        }
    }
}
