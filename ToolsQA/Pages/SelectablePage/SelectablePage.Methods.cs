using OpenQA.Selenium;

namespace ToolsQA.Pages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver)
          : base(driver)
        {
        }

        public override string Url => "http://demoqa.com/selectable";
    }
}
