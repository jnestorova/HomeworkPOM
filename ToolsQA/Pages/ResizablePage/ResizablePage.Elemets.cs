using OpenQA.Selenium;

namespace ToolsQA.Pages.ResizablePage
{
    public partial class ResizablePage
    {
        public IWebElement ResizeArrow => Driver.FindElement(By.XPath("//*[@id='resizableBoxWithRestriction']/span"));
    }
}
