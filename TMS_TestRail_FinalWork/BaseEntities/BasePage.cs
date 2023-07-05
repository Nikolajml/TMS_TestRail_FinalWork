using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Core;
using TMS_TestRail_FinalWork.Utilities.Configuration;

namespace TMS_TestRail_FinalWork.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;
        protected WaitService WaitService;

        public BasePage(IWebDriver driver, bool openPageByUrl)
        {
            Driver = driver;
            WaitService = new WaitService(Driver);

            if (openPageByUrl)
            {
                OpenPageByUrl();
            }
        }

        public abstract bool IsPageOpened();
        protected abstract string GetEndpoint();

        private void OpenPageByUrl()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + GetEndpoint());
        }
    }
}
