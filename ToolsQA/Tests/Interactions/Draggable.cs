using ToolsQA.Pages.DraggablePage;
using ToolsQA.Tests;
using NUnit.Framework;
using OpenQA.Selenium;


namespace ToolsQA.Tests.Interactions
{
    [TestFixture]
    public class Draggable : BaseTest
    {
        private DraggablePage _draggablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _draggablePage = new DraggablePage(Driver);
            _draggablePage.NavigateTo();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void DragElementPositionBottomRight_SimpleTab()
        {
            //Arange
            var sourcePosition = _draggablePage.DragMeElement;

            //Act
            _draggablePage.SimpleTab.Click();

            Builder.DragAndDropToOffset(_draggablePage.DragMeElement, 410, 210)
                   .Perform();

            //Assert
            Assert.AreNotEqual(_draggablePage.DragMeElement.Location, sourcePosition);
        }

        [Test]
        public void MoveOnlyElementY_AxisRestrictionTab()
        {
            //Arange
            var sourcePosition = _draggablePage.ElementY;

            //Act
            _draggablePage.AxisRestrictionTab.Click();

            Builder.DragAndDropToOffset(_draggablePage.ElementY, 0, 220)
                   .Perform();

            //Assert
            Assert.AreNotEqual(_draggablePage.ElementY.Location, sourcePosition);
        }

        [Test]
        public void MoveOnlyElementX_AxisRestrictionTab()
        {
            //Arange
            var sourcePosition = _draggablePage.ElementX;

            //Act
            _draggablePage.AxisRestrictionTab.Click();

            Builder.DragAndDropToOffset(_draggablePage.ElementX, 220, 0)
                   .Perform();

            //Assert
            Assert.AreNotEqual(_draggablePage.ElementX.Location, sourcePosition);
        }
    }
}
