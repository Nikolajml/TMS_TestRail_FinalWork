using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TMS_TestRail_FinalWork.Pages
{
    public class CreatedProjectPage : BasePage
    {        
        private static string END_POINT = "";

        private static readonly By TestCasesButtonBy = By.Id("navigation-suites");
        private static readonly By DialogBodyBy = By.ClassName("dialog-body-date");

        public CreatedProjectPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public CreatedProjectPage(IWebDriver? driver) : base(driver, false)
        {

        }

        public override bool IsPageOpened()
        {
            return WaitService.GetVisibleElement(DialogBodyBy) != null;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public AddTestCasePage ClickTestCasesButton()
        {
            Driver.FindElement(TestCasesButtonBy).Click();
            return new AddTestCasePage(Driver);
        }
            
    }
}
