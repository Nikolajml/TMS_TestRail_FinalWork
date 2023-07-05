using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Core;
using static System.Net.Mime.MediaTypeNames;

namespace TMS_TestRail_FinalWork.Pages
{
    public class DashboardPage : BasePage
    {
        private static string END_POINT = "index.php?/dashboard";
                
        private static readonly By AddProjectButtonBy = By.Id("sidebar-projects-add");
        private static readonly By DialogBodyBy = By.ClassName("dialog-body-date");
        private static readonly By AdministrationButtonBy = By.Id("navigation-admin");
        private static readonly By SearchQueryInputBy = By.Id("search_query");
        private static readonly By SearchQueryEnterBy = By.Id("search_query");
        private static readonly By ErrorDialogMessageBy = By.CssSelector("#messageDialog .dialog-body .dialog-message");
        private static readonly By SearchDialogCategoryBy = By.CssSelector("a[href$='[]=1']");
        

        public DashboardPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public DashboardPage(IWebDriver? driver) : base(driver, false)
        {

        }
                   
        public override bool IsPageOpened()
        {
            return WaitService.GetVisibleElement(DialogBodyBy) != null;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }               

        public AddProjectPage AddProject()
        {
            Driver.FindElement(AddProjectButtonBy).Click();
            return new AddProjectPage(Driver);
        }

        public OverviewPage NavigateToOverviewPage() 
        {
            Driver.FindElement(AdministrationButtonBy).Click();
            return new OverviewPage(Driver);
        }

        private void InputInSearchField()
        {
            Driver.FindElement(SearchQueryInputBy).Click();
        }
        private void EnterInSearchField(string text)
        {
            Driver.FindElement(SearchQueryEnterBy).SendKeys(text);
        }                

        public DashboardPage EnterDataInSearchField(string text)
        {            
            EnterInSearchField(text);
            return this;
        }

        public string GetErrorLimitDialogMessage()
        {
            return Driver.FindElement(ErrorDialogMessageBy).Text;
        }

        public bool WaitDialogWindow()
        {
            return WaitService.GetVisibleElement(ErrorDialogMessageBy) != null;
        }                

        public Dashboard_SearchProject_Page NavigateToProjectCategorySearch()
        {
            InputInSearchField();
            SelectProjectCategory();
            return new Dashboard_SearchProject_Page(Driver);
        }

        private void SelectProjectCategory()
        {                
            Driver.FindElement(SearchDialogCategoryBy).Click();    
        }        
    }
}