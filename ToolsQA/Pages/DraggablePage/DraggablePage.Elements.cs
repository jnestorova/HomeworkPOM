using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsQA.Pages.DraggablePage
{
    public partial class DraggablePage
    {
        public IWebElement SimpleTab => Driver.FindElement(By.Id("draggableExample-tab-simple"));

        public IWebElement DragMeElement => Driver.FindElement(By.XPath("//*[@id='dragBox']"));

        public IWebElement AxisRestrictionTab => Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));

        public IWebElement ElementY => Driver.FindElement(By.Id("restrictedY"));

        public IWebElement ElementX => Driver.FindElement(By.Id("restrictedX"));
    }
}
