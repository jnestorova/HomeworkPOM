using GoogleSearch.Factories;
using GoogleSearch.Models;
using GoogleSearch.Pages.GooglePage;
using NUnit.Framework;

namespace GoogleSearch.Tests.Selenium
{
    [TestFixture]
    public class Google : BaseTest
    {
        private GooglePage _googlePage;
        private GoogleModel _action;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _googlePage = new GooglePage(Driver);
            _googlePage.NavigateTo();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void SeleniumSearch()
        {
            //Act
            _action = GoogleSearchFactory.Create();
            _googlePage.ActionsForm(_action);

            //Assert
            var actualTitle = Driver.Title;

            Assert.AreEqual("SeleniumHQ Browser Automation", actualTitle);
        }
    }
}
