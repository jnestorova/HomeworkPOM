using OpenQA.Selenium;

namespace ToolsQA.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(IWebDriver driver)
           : base(driver)
        {
        }

        public override string Url => "http://demoqa.com/resizable";
    }
}
