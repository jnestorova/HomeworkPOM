using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace ToolsQA.Pages.SortablePage
{
    public partial class SortablePage
    {
        public List<IWebElement> ListOfOptions => Driver.FindElements(By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class, 'list-group-item')]")).ToList();

        public IWebElement Container => Driver.FindElement(By.CssSelector("#demo-tabpane-list > div"));
    }
}
