using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Models;

namespace TMS_TestRail_FinalWork.Pages
{
    public class IntegrationPage : BasePage
    {
        private static string END_POINT = "index.php?/admin/integration";

        private static readonly By ConfigureIntegrationButtonBy = By.CssSelector(".text-right-integration .config-button");
        private static readonly By DialogTitleBy = By.Id("ui-dialog-title-jiraIntegrationDialog");        

        public IntegrationPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public IntegrationPage(IWebDriver? driver) : base(driver, false)
        {

        }

        public override bool IsPageOpened()
        {
            return WaitService.GetVisibleElement(ConfigureIntegrationButtonBy) != null;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public string GetDialogTitle()
        {
            return Driver.FindElement(DialogTitleBy).Text;
        }

        public void ClickToConfigureIntegrationButton()
        {
            Driver.FindElement(ConfigureIntegrationButtonBy).Click();
        }
    }
}
