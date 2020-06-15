using GoogleSearch.Page;
using OpenQA.Selenium;

namespace SoftUni.Pages.SoftUniPage
{
    public partial class SoftUniPage : BasePage
    {
        public SoftUniPage(IWebDriver driver)
               : base(driver)
        {
        }

        public override string Url => "https://softuni.bg/";

    }
}
