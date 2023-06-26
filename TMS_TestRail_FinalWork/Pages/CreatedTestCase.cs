using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_TestRail_FinalWork.Pages
{
    public class CreatedTestCase : BasePage
    {
        private static string END_POINT = "";

        private static readonly By SuccessMessageBy = By.ClassName("message message-success");

        public CreatedTestCase(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public CreatedTestCase(IWebDriver? driver) : base(driver, false)
        {

        }

        public override bool IsPageOpened()
        {
            return WaitService.GetVisibleElement(SuccessMessageBy) != null;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public string GetSuccessMessage()
        {
            return Driver.FindElement(SuccessMessageBy).Text;
        }
    }
}
