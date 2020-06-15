using OpenQA.Selenium;

namespace ToolsQA.Pages.SelectablePage
{
    public partial class SelectablePage
    {
        public IWebElement ListItemOne => Driver.FindElement(By.XPath("//*[@id='verticalListContainer']/li[1]"));

        public IWebElement GridTab => Driver.FindElement(By.Id("demo-tab-grid"));

        public IWebElement NumberTwo => Driver.FindElement(By.XPath("//*[normalize-space(text())='Two']"));
    }
}
