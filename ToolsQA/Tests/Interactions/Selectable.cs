using NUnit.Framework;
using OpenQA.Selenium;
using ToolsQA.Pages.SelectablePage;
using ToolsQA.Tests;
using ToolsQA.Utilities.Extentions;

namespace ToolsQA.Tests.Interactions
{
    [TestFixture]
    public class Selectable : BaseTest
    {
        private SelectablePage _selectablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _selectablePage = new SelectablePage(Driver);
            _selectablePage.NavigateTo();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void SelectCrasJustoOdio_FirstListItem()
        {
            //Arange
            var colorBefore = _selectablePage.ListItemOne.GetCssColor();

            //Act
            _selectablePage.ListItemOne.Click();

            //Assert
            Assert.AreNotEqual(colorBefore, _selectablePage.ListItemOne.GetCssColor());
        }

        [Test]
        public void SelectNumberTwoFromTheGrid()
        {
            //Arrange
            var colorBefore = _selectablePage.NumberTwo.GetCssColor();

            //Act
            _selectablePage.GridTab.Click();
            _selectablePage.NumberTwo.Click();

            //Assert
            Assert.AreNotEqual(colorBefore, _selectablePage.NumberTwo.GetCssColor());
        }
    }
}
