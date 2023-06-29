using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Core;

namespace TMS_TestRail_FinalWork.Pages
{
    public class DataManagement_Attachments_Page : BasePage
    {
        private static string END_POINT = "";
        
        private static readonly By LibraryDropzoneButtonBy = By.Id("libraryDropzoneButton");
        private static readonly By FileInputBy = By.XPath("//div[@id='jstree-marker']/following::input");
        string filePath = "D:/TeachMeSkills/Новая папка/TMS_TestRail_FinalWork/TMS_TestRail_FinalWork/Utilities/FileForUpload.txt";

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

        void InputPathToUploadFile()
        {
            Driver.FindElement(FileInputBy).SendKeys(filePath);
        }

        public DataManagement_Attachments_Page UploadFile()
        {
            InputPathToUploadFile();
            return this;
        }
    }
}
