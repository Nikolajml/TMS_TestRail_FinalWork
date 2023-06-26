using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Core;

namespace TMS_TestRail_FinalWork.Pages
{
    public class TestCasesPage : BasePage
    {
        private static string END_POINT = "";

        //private static readonly By NameInputBy = By.Id("name");
        //private static readonly By AnounecementInpuBy = By.Id("announcement");
        private static readonly By AddTestCaseButtonBy = By.ClassName("button button-left button-add");

        public TestCasesPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public TestCasesPage(IWebDriver? driver) : base(driver, false)
        {

        }

        public override bool IsPageOpened()
        {
            return WaitService.GetVisibleElement(AddTestCaseButtonBy) != null;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public void ClickAddTestCaseButton()
        {
            Driver.FindElement(AddTestCaseButtonBy).Click();
        }
    }
}
