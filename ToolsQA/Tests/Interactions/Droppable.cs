using ToolsQA.Pages.DroppablePage;
using ToolsQA.Tests;
using ToolsQA.Utilities.Extentions;
using NUnit.Framework;
using OpenQA.Selenium;


namespace ToolsQA.Tests.Interactions
{
    [TestFixture]
    public class Droppable : BaseTest
    {
        private DroppablePage _droppablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _droppablePage = new DroppablePage(Driver);
            _droppablePage.NavigateTo();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void TargetColorChanged_WhenDragMeAccepted()
        {
            //Arange
            var colorBefore = _droppablePage.DropHere.GetCssColor();

            //Act
            _droppablePage.SimpleTab.Click();
            Builder.DragAndDrop(_droppablePage.DragMe, _droppablePage.DropHere).Perform();

            //Assert
            Assert.AreNotEqual(colorBefore, _droppablePage.DropHere.GetCssColor());
        }

        [Test]
        public void TargetIsActive_When_DragAcceptableElement()
        {
            //Act
            _droppablePage.AcceptTab.Click();

            Builder.MoveToElement(_droppablePage.Acceptable)
                   .ClickAndHold()
                   .MoveByOffset(35, 35)
                   .ClickAndHold()
                   .Perform();

            //Assert
            var classAfterAction = Driver.FindElement(By.Id("droppable")).GetAttribute("class");
            StringAssert.Contains("ui-droppable-active", classAfterAction);
        }

        [Test]
        public void TargetColorNotChanged_WhenDragNotAcceptableElement()
        {
            //Act
            _droppablePage.AcceptTab.Click();

            Builder.MoveToElement(_droppablePage.NotAcceptable)
                   .ClickAndHold()
                   .MoveByOffset(100, 80)
                   .Perform();

            //Assert
            var classAfterAction = Driver.FindElement(By.Id("droppable")).GetAttribute("class");
            StringAssert.DoesNotContain(classAfterAction, "ui-droppable-active");
        }
    }
}
