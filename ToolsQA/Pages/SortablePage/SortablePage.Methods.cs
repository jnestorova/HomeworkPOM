using OpenQA.Selenium;

namespace ToolsQA.Pages.SortablePage
{
    public partial class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver)
         : base(driver)
        {
        }

        public override string Url => "http://demoqa.com/sortable";
    }
}
