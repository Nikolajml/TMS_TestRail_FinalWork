using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;

namespace TMS_TestRail_FinalWork.Pages
{
    public class Dashboard_SearchProject_Page : BasePage
    {
        private static string END_POINT = "index.php?/new_search/results&category[]=1";                
                
        private static readonly By SearchByTitleBy = By.ClassName("sidebar-h1");
        private static readonly By SearchQueryInputBy = By.Id("searchQueryDetailed");
        private static readonly By SearchQueryEnterBy = By.Id("searchQueryDetailed");
        private static readonly By ErrorDialogMessageDisplayedBy = By.CssSelector("#messageDialog .dialog-body .dialog-message");



        public Dashboard_SearchProject_Page(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public Dashboard_SearchProject_Page(IWebDriver? driver) : base(driver, false)
        {

        }

        public override bool IsPageOpened()
        {
            return WaitService.GetVisibleElement(SearchByTitleBy) != null;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        private void InputInSearchField()
        {
            Driver.FindElement(SearchQueryInputBy).Click();
        }

        private void EnterInSearchField(string text)
        {
            Driver.FindElement(SearchQueryEnterBy).SendKeys(text);
        }

        private void PressEnterInSearchField()
        {
            Driver.FindElement(SearchQueryInputBy).SendKeys(Keys.Enter);
        }

        public Dashboard_SearchProject_Page EnterDataInSearchField(string text)
        {
            InputInSearchField();
            EnterInSearchField(text);
            PressEnterInSearchField();
            return this;
        }

        public bool IsPresentErrorLimitDialogMessage()
        {
            return Driver.FindElement(ErrorDialogMessageDisplayedBy).Displayed;
        }

        public bool WaitDialogWindow()
        {
            return WaitService.GetVisibleElement(ErrorDialogMessageDisplayedBy) != null;
        }


    }
}
