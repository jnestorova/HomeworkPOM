using ToolsQA.Pages.SortablePage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToolsQA.Tests.Interactions
{
    [TestFixture]
    public class Sortable : BaseTest
    {
        private SortablePage _sortablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _sortablePage = new SortablePage(Driver);
            _sortablePage.NavigateTo();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void VerifyOptionPlacesAreSwitchedCorrectly_When_DragAndDrop()
        {
            //Arrange
            var index = 3;

            //Act
            Builder.DragAndDropToOffset(_sortablePage.ListOfOptions[index], -100, 50).Perform();

            //Assert
            _sortablePage.AssertTextByIndex("Five", index);
        }

        [Test]
        public void VerifyAllOptionsAreOrderedProperly_When_DragAndDropSingleOption()
        {
            //Act
            Builder.DragAndDropToOffset(_sortablePage.ListOfOptions[4], 100, 50).Perform();

            //Assert
            Assert.IsTrue(_sortablePage.ListOfOptions.All(o => o.Location.X == _sortablePage.Container.Location.X));
        }
    }
}
