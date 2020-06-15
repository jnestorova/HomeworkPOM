using NUnit.Framework;
using SoftUni.Pages.SoftUniPage;

namespace SoftUni.Tests.QAAutomation
{
    [TestFixture]
    public class SoftUni : BaseTest
    {
        private SoftUniPage _softUniPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _softUniPage = new SoftUniPage(Driver);
            _softUniPage.NavigateTo();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void QAAutomationCourse()
        {
            //Act
            _softUniPage.Courses.Click();
            _softUniPage.ActiveModulsSection.Click();
            _softUniPage.QaCourseLink.Click();
            _softUniPage.CoursesInTheModule.Click();


            //Assert
            var actualHeader = _softUniPage.Header.Text;

            Assert.AreEqual("QA Automation - май 2020", actualHeader);
        }
    }
}