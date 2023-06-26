using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Models;

namespace TMS_TestRail_FinalWork.Pages
{
    public class AddTestCasePage : BasePage
    {
        private static string END_POINT = "";

        private static readonly By TitleInputBy = By.Id("title");
        private static readonly By PreconditionsInputBy = By.Id("custom_preconds_display");
        private static readonly By StepsInputBy = By.Id("custom_steps_display");
        private static readonly By ExpectedResultInputBy = By.Id("custom_expected_display");
        private static readonly By AddTestCaseButtonBy = By.Id("accept");


        public AddTestCasePage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public AddTestCasePage(IWebDriver? driver) : base(driver, false)
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

        void SetTestCaseTitle(string title)
        {
            Driver.FindElement(TitleInputBy).SendKeys(title);
        }

        void SetTestCasePreconditions(string preconditions)
        {
            Driver.FindElement(PreconditionsInputBy).SendKeys(preconditions);
        }

        void SetTestCaseSteps(string steps)
        {
            Driver.FindElement(StepsInputBy).SendKeys(steps);
        }

        void SetTestCaseExpectedReulst(string expectedResult)
        {
            Driver.FindElement(ExpectedResultInputBy).SendKeys(expectedResult);
        }

        void ClickAddTestCaseButton()
        {
            Driver.FindElement(AddTestCaseButtonBy).Click();
        }

        public CreatedTestCase CreateTestCase(Case test_case)
        {
            SetTestCaseTitle(test_case.Title);
            SetTestCasePreconditions(test_case.Preconditions);
            SetTestCaseSteps(test_case.Steps);
            SetTestCaseExpectedReulst(test_case.ExpectedResult);
            ClickAddTestCaseButton();
            return new CreatedTestCase(Driver);
        }
    }
}
