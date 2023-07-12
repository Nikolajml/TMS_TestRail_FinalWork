using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Core;

namespace TMS_TestRail_FinalWork.Pages
{
    public class DataManagement_Attachments_Page : BasePage
    {
        private static string END_POINT = "";
        
        private static readonly By LibraryDropzoneButtonBy = By.Id("libraryDropzoneButton");
        private static readonly By FileInputBy = By.CssSelector("#jstree-marker+.dz-hidden-input");                
        

        public DataManagement_Attachments_Page(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public DataManagement_Attachments_Page(IWebDriver? driver) : base(driver, false)
        {

        }

        public override bool IsPageOpened()
        {
            return WaitService.GetVisibleElement(LibraryDropzoneButtonBy) != null;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        void InputPathToUploadFile(string filePath)
        {
            Driver.FindElement(FileInputBy).SendKeys(filePath);
        }

        public DataManagement_Attachments_Page UploadFile(string filePath)
        {
            InputPathToUploadFile(filePath);
            return this;
        }
    }
}
