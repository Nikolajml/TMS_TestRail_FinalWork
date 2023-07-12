using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Models;
using TMS_TestRail_FinalWork.Wreppers;

namespace TMS_TestRail_FinalWork.Pages
{
    public class AddProjectPage : BasePage
    {
        private static string END_POINT = "index.php?/admin/projects/add";
                
        private static readonly By NameInputBy = By.Id("name");
        private static readonly By AnounecementInpuBy = By.Id("announcement_display");
        private static readonly By AddProjectButtonBy = By.Id("accept");

        public AddProjectPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public AddProjectPage(IWebDriver? driver) : base(driver, false)
        {

        }

        public override bool IsPageOpened()
        {
            return WaitService.GetVisibleElement(NameInputBy) != null;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }                             

        void SetProjectName(string projectName)
        {
            Driver.FindElement(NameInputBy).SendKeys(projectName);
        }

        void SetProjectAnnouncement(string announcement)
        {
            Driver.FindElement(AnounecementInpuBy).SendKeys(announcement);
        }

        void ClickAddProjectButton()
        {
            Driver.FindElement(AddProjectButtonBy).Click();
        }

        public ProjectsPage CreateProject(Project project)
        {
            SetProjectName(project.Name);
            SetProjectAnnouncement(project.Announcement);
            ClickAddProjectButton();
            return new ProjectsPage(Driver);
        }
    }
}
