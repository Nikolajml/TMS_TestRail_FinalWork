using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Core;

namespace TMS_TestRail_FinalWork.Pages
{
    public class ProjectsPage : BasePage
    {
        private static string END_POINT = "index.php?/admin/projects/overview";
                
        private static readonly By MessageBy = By.ClassName("message-success");
        private static readonly By DeleteIconBy = By.ClassName("icon-small-delete");
        private static readonly By DeleteCheckboxBy = By.XPath("//span[@class='dialog-confirm-busy']/following::input");
        private static readonly By OkButtonBy = By.CssSelector(".ui-dialog .dialog .dialog-buttons-highlighted .dialog-action-default");

        public ProjectsPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public ProjectsPage(IWebDriver? driver) : base(driver, false)
        {

        }

        public override bool IsPageOpened()
        {
            return WaitService.GetVisibleElement(MessageBy) != null;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }            

        public string GetSuccessCreatedMessage()
        {
            return Driver.FindElement(MessageBy).Text;
        }

        public string GetSuccessDeletedMessage()
        {
            return Driver.FindElement(MessageBy).Text;
        }               

        void ClickDeletIcon()
        {
            Driver.FindElement(DeleteIconBy).Click();
        }

        void ClickDeleteProjectCheckBox()
        {
            Driver.FindElement(DeleteCheckboxBy).Click();
        }

        void ClickOkButton()
        {
            Driver.FindElement(OkButtonBy).Click(); 
        }

        public ProjectsPage DeleteProject()
        {
            ClickDeletIcon();
            ClickDeleteProjectCheckBox();
            ClickOkButton();
            return this;
        }
    }
}
