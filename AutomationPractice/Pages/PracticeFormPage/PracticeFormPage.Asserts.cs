using NUnit.Framework;
using OpenQA.Selenium;
using AutomationPractice.Models;

namespace AutomationPractice.Pages.PracticeFormPage
{
    public partial class PracticeFormPage : BasePage
    {
        public void AssertErrorMessageBackgroundColor(IWebElement element)
        {
            this.WaitForLoad();
            IWebElement errorMessage = Driver.FindElement(By.XPath("//*[@class='alert alert-danger']"));
            Assert.AreEqual("rgba(243, 81, 92, 1)", errorMessage.GetCssValue("background-color"));
        }
    }
}
