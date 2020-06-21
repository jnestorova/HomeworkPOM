using NUnit.Framework;

namespace SoftUni.Pages.SoftUniPage
{
    public partial class SoftUniPage
    {
        public void ValidateHeaderText(string expected)
        {
            var actualHeader = Header.Text;
            Assert.AreEqual("QA Automation - май 2020", actualHeader);
            //Assert.True(actualHeader.Contains(expected));
        }
    }
}
