using OpenQA.Selenium;

namespace ToolsQA.Pages.DroppablePage
{
    public partial class DroppablePage
    {  
        public IWebElement AcceptTab => Driver.FindElement(By.Id("droppableExample-tab-accept"));

        public IWebElement Acceptable => Driver.FindElement(By.Id("acceptable"));

        public IWebElement NotAcceptable => Driver.FindElement(By.Id("notAcceptable"));

        public IWebElement SimpleTab => Driver.FindElement(By.Id("droppableExample-tab-simple"));

        public IWebElement DragMe => Driver.FindElement(By.Id("draggable"));

        public IWebElement DropHere => Driver.FindElement(By.Id("droppable"));
    }
}
