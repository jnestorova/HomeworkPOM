using AutomationPractice.Models;
using AutomationPractice.Utilities.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPractice.Pages.PracticeFormPage
{
    public partial class PracticeFormPage : BasePage
    {
        public PracticeFormPage(IWebDriver driver)
            : base(driver)
        {
        }
        public void FillForm(PracticeFormModel user)
        {
            Title.Click();
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Password.SendKeys(user.Password);
            FirstAddressField.SendKeys(user.FirstAddressField);
            City.SendKeys(user.City);
            SelectElement State = new SelectElement(Driver.
                FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[7]/div/select")));
            State.SelectByText("California");
            PostCode.SendKeys(user.PostCode);
            MobilePhone.SendKeys(user.MobilePhone);
                     
            Driver.ScrollTo(RegisterButton);
            RegisterButton.Click();
        }
    }
}
