using OpenQA.Selenium;
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
                
        private static readonly By SuccessMessageBy = By.ClassName("message-success");

        public ProjectsPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public ProjectsPage(IWebDriver? driver) : base(driver, false)
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
