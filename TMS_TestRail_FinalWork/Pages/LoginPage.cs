using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Core;
using TMS_TestRail_FinalWork.Models;
using TMS_TestRail_FinalWork.Wreppers;

namespace TMS_TestRail_FinalWork.Pages
{
    public class LoginPage : BasePage
    {
        private static string END_POINT = "";
                
        private static readonly By EmailInputBy = By.Id("name");
        private static readonly By PasswordInputBy = By.Id("password");
        private static readonly By RememberMeCheckboxBy = By.Id("rememberme");
        private static readonly By LoginInButtonBy = By.Id("button_primary");
        private static readonly By ErrorMessageBy = By.ClassName("error-text");

        public LoginPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }
        public LoginPage(IWebDriver driver) : base(driver, false)
        {

        }

        public override bool IsPageOpened()
        {
            return WaitService.GetVisibleElement(LoginInButtonBy) != null;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
                                                       
        void SetUserName(string username)
        {
            Driver.FindElement(EmailInputBy).SendKeys(username);
        }

        void SetPassword(string password)
        {
            Driver.FindElement(PasswordInputBy).SendKeys(password);
        }

        void ClickRememberMeCheckBox()
        {
            Driver.FindElement(RememberMeCheckboxBy).Click();
        }

        void ClickLoginButton()
        {
            Driver.FindElement(LoginInButtonBy).Click();
        }

        public string GetErrorMessage()
        {
            return Driver.FindElement(ErrorMessageBy).Text;
        }

        public DashboardPage SuccessfulLogin(User user)
        {
            SetUserName(user.Username);
            SetPassword(user.Password);
            ClickRememberMeCheckBox();
            ClickLoginButton();
            return new DashboardPage(Driver);
        }

        public LoginPage LoginWithIncorrectCredential(User user)
        {
            SetUserName(user.Username);
            SetPassword(user.Password);
            ClickLoginButton();
            return this;
        }
    }
}
