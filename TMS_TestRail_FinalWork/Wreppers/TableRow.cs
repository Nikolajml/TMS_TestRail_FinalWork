using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_TestRail_FinalWork.Wreppers
{
    public class TableRow
    {
        private UIElement _uiElement;

        public TableRow(IWebDriver? driver, By @by)
        {
            _uiElement = new UIElement(driver, @by);
        }

        public TableRow(IWebDriver? driver, IWebElement webElement)
        {
            _uiElement = new UIElement(driver, webElement);
        }

    }
}
