using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsQA.Pages.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver)
           : base(driver)
        {
        }

        public override string Url => "http://demoqa.com/dragabble";
    }
}
