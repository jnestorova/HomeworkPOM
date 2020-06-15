using ToolsQA.Pages.ResizablePage;
using ToolsQA.Tests;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ToolsQA.Tests.Interactions
{
    [TestFixture]

    public class Resizable : BaseTest
    {
        private ResizablePage _resizablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _resizablePage = new ResizablePage(Driver);
            _resizablePage.NavigateTo();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void ResizeToMaxSize_TheResizableBoxWithRestriction()
        {
            //Arange
            var startPosition = _resizablePage.ResizeArrow.Location;

            //Act
            _resizablePage.ResizeArrow.Click();

            Builder.ClickAndHold(_resizablePage.ResizeArrow)
                   .MoveByOffset(300, 100)
                   .Perform();

            //Assert
            Assert.AreNotEqual(_resizablePage.ResizeArrow.Location, startPosition);
        }

        [Test]
        public void ResizeToMinSize_TheResizableBoxWithRestriction()
        {
            //Arange
            var startPosition = _resizablePage.ResizeArrow.Location;

            //Act
            _resizablePage.ResizeArrow.Click();

            Builder.ClickAndHold(_resizablePage.ResizeArrow)
                   .MoveByOffset(-50, -50)
                   .Perform();

            //Assert
            Assert.AreNotEqual(_resizablePage.ResizeArrow.Location, startPosition);
        }
    }
}