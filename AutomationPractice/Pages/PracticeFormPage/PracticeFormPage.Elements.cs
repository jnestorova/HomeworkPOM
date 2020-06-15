using OpenQA.Selenium;

namespace AutomationPractice.Pages.PracticeFormPage
{
    public partial class PracticeFormPage : BasePage
    {
        public IWebElement Title => Driver.FindElement(By.XPath("//*[@id='id_gender2']"));

        public IWebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement LastName => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement Password => Driver.FindElement(By.Id("passwd"));

        public IWebElement FirstAddressField => Driver.FindElement(By.Id("address1"));

        public IWebElement City => Driver.FindElement(By.Id("city"));

        public IWebElement State => Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[7]/div/select"));

        public IWebElement PostCode => Driver.FindElement(By.Id("postcode"));

        public IWebElement MobilePhone => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));

        public IWebElement Header => Driver.FindElement(By.XPath("//*[@class='page-heading']"));

        public IWebElement ErrorTextMessage => Driver.FindElement(By.XPath("//*[@id='center_column']/div/ol/li"));
    }
}
