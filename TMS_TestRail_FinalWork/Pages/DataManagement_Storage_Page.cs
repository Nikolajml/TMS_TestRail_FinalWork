using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Core;

namespace TMS_TestRail_FinalWork.Pages
{
    public  class DataManagement_Storage_Page : BasePage
    {
        private static string END_POINT = "index.php?/admin/subscription";
        
        private static readonly By AttachmentsTabBy = By.Id("navigation-data-management-attachments");

        public DataManagement_Storage_Page(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public DataManagement_Storage_Page(IWebDriver? driver) : base(driver, false)
        {

        }

        public override bool IsPageOpened()
        {
            return WaitService.GetVisibleElement(AttachmentsTabBy) != null;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        void ClickAttachmentsTab()
        {
            Driver.FindElement(AttachmentsTabBy).Click();
        }

        public DataManagement_Attachments_Page NavigateToDataManagement_Attachments_Page()
        {
            ClickAttachmentsTab();
            return new DataManagement_Attachments_Page(Driver);
        }


    }
}
