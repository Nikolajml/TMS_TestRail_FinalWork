using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_TestRail_FinalWork.Wreppers
{
    public class Button
    {
        private UIElement _uiElement;

        public Button(IWebDriver? driver, By @by)
        {
            _uiElement = new UIElement(driver, @by);
        }

        public void Click() => _uiElement.Click();

        public string Text => _uiElement.Text;

        public bool Displayed => _uiElement.Displayed;
    }
}
