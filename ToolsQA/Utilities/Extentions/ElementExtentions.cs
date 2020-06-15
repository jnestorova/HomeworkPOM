using System;
using OpenQA.Selenium;
using System.Threading;

namespace ToolsQA.Utilities.Extentions
{
  public static class ElementExtentions
    {
        public static string GetCssColor(this IWebElement element)
        {
            return element.GetCssValue("background-color");
        }
    }
}
