using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private static readonly By SearchQueryInput = By.Id("search_query");
        private static readonly By SearchQueryEnter = By.Id("search_query");
        private static readonly By ErrorDialogMessage = By.CssSelector("#messageDialog .dialog-body .dialog-message");
        

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
            Driver.FindElement(SearchQueryInput).Click();           
        }

        private void EnterInSearchField(string text)
        {
            Driver.FindElement(SearchQueryEnter).SendKeys(text);
        }
                

        public void EnterDataInSearchField(string text)
        {
            InputInSearchField();
            EnterInSearchField(text);
        }
               
        
        public string GetErrorLimitDialogMessage()
        {
            return Driver.FindElement(ErrorDialogMessage).Text;
        }
    }
}