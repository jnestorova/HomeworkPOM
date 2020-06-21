using GoogleSearch.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace SoftUni.Pages.SoftUniPage
{
    public partial class SoftUniPage : BasePage
    {
        public SoftUniPage(IWebDriver driver)
               : base(driver)
        {
        }

        public override string Url => "https://softuni.bg/";


        public void PerformNavigationActions()
        {
            Courses.Click();
            ActiveModulsSection.Click();
            QaCourseLink.Click();
            CoursesInTheModule.Click();
        }      
    }
}
