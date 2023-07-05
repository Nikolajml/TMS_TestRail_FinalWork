using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Models;

namespace TMS_TestRail_FinalWork.Pages
{
    public class AddUserPage : BasePage
    {
        private static string END_POINT = "index.php?/admin/users/add";

        private static readonly By NameInputBy = By.Id("name");
        private static readonly By EmailInpuBy = By.Id("email");
        private static readonly By AddUserButtonBy = By.Id("accept");

        public AddUserPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public AddUserPage(IWebDriver? driver) : base(driver, false)
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

        void SetUserName(string userName)
        {
            Driver.FindElement(NameInputBy).SendKeys(userName);
        }

        void SetUserEmail(string email)
        {
            Driver.FindElement(EmailInpuBy).SendKeys(email);
        }

        void ClickAddUserButton()
        {
            Driver.FindElement(AddUserButtonBy).Click();
        }

        public AddUserPage CreateUser(User user)
        {
            SetUserName(user.Username);
            SetUserEmail(user.Email);
            ClickAddUserButton();
            return this;
        }
    }
}
