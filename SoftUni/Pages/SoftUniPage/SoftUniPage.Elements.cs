using OpenQA.Selenium;

namespace SoftUni.Pages.SoftUniPage
{
    public partial class SoftUniPage
    {
        public IWebElement Courses => Driver.FindElement(By.XPath("//*[@id='header-nav']/div[1]/ul/li[2]/a/span"));

        public IWebElement ActiveModulsSection => Driver.
            FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/div/div[1]"));

        public IWebElement QaCourseLink => Driver.FindElement(By.LinkText("Quality Assurance - октомври 2019"));
        
        public IWebElement CoursesInTheModule => Driver.FindElement(By.XPath("//h4[normalize-space(text())='QA Automation']"));

        public IWebElement Header => Driver.FindElement(By.XPath(@"/html/body/div[2]/header/h1"));
    }
}
