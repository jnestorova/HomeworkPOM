using NUnit.Framework;

namespace ToolsQA.Pages.SortablePage
{
    public partial class SortablePage
    {
        public void AssertTextByIndex(string expectedText, int index)
        {
            Assert.AreEqual(expectedText, ListOfOptions[index].Text);
        }
    }
}
