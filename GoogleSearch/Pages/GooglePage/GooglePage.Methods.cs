using GoogleSearch.Models;
using GoogleSearch.Page;
using OpenQA.Selenium;

namespace GoogleSearch.Pages.GooglePage
{
    public partial class GooglePage : BasePage
    { 
            public GooglePage(IWebDriver driver)
               : base(driver)
            {
            }

        public override string Url => "https://www.google.com/";

        public void ActionsForm(GoogleModel action)
        {
            SearchInput.SendKeys("Selenium");
            Logo.Click();
            SearchButton.Click();
            SeleniumResult.Click();
        }
    }
}
