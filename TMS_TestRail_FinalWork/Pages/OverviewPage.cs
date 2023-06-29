using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Core;

namespace TMS_TestRail_FinalWork.Pages
{
    public class OverviewPage : BasePage
    {
        private static string END_POINT = "index.php?/admin/projects/add";

        private static readonly By ProjectsButtonBy = By.Id("navigation-sub-projects");
        
        public OverviewPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public OverviewPage(IWebDriver? driver) : base(driver, false)
        {

        }

        public override bool IsPageOpened()
        {
            return WaitService.GetVisibleElement(ProjectsButtonBy) != null;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public ProjectsPage NavigateToProjectsPage()
        {
            Driver.FindElement(ProjectsButtonBy).Click();
            return new ProjectsPage(Driver);
        }

    }
}
