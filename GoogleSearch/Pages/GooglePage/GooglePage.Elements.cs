using OpenQA.Selenium;

namespace GoogleSearch.Pages.GooglePage
{
    public partial class GooglePage
    {
        public IWebElement SearchInput => Driver.FindElement(By.XPath(@"//input[@class='gLFyf gsfi']"));

        public IWebElement Logo => Driver.FindElement(By.Id("hplogo"));

        public IWebElement SearchButton => Driver.
            FindElement(By.XPath(@"//*[@id='tsf']/div[2]/div[1]/div[3]/center/input[1]"));

        public IWebElement SeleniumResult => Driver.FindElement(By.ClassName("iUh30"));
    }
}
