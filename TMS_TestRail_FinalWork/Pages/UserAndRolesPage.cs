using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Core;
using TMS_TestRail_FinalWork.Models;

namespace TMS_TestRail_FinalWork.Pages
{
    public class UserAndRolesPage : BasePage
    {
        private static string END_POINT = "index.php?/admin/users/overview";

        private static readonly By AddUserButtonBy = By.CssSelector("#sidebar-add-users .button");
        private static readonly By SuccessCreateUserMessageBy = By.ClassName("message-success");

        public UserAndRolesPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public UserAndRolesPage(IWebDriver? driver) : base(driver, false)
        {

        }

        public override bool IsPageOpened()
        {
            return WaitService.GetVisibleElement(AddUserButtonBy) != null;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }                

        void ClickAddUserButton()
        {
            Driver.FindElement(AddUserButtonBy).Click();
        }

        public AddUserPage NavigateToAddUserPage()
        {
            ClickAddUserButton();
            return new AddUserPage(Driver);
        }

        public string GetSuccessCreatedUserMessage()
        {
            return Driver.FindElement(SuccessCreateUserMessageBy).Text;
        }
    }
}
