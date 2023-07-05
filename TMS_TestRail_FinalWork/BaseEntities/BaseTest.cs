using Allure.Commons;
using NLog;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Core;
using TMS_TestRail_FinalWork.Pages;
using TMS_TestRail_FinalWork.Utilities.Configuration;
using NUnit.Framework.Interfaces;

namespace TMS_TestRail_FinalWork.BaseEntities
{
    [AllureNUnit]
    [Parallelizable(ParallelScope.All)]
    public class BaseTest
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        protected IWebDriver Driver;
        private AllureLifecycle _allure;
        public LoginPage LoginPage;
        public ProjectsPage ProjectsPage;
        public DashboardPage DashboardPage;
        public Dashboard_SearchProject_Page dashboard_SearchProject_Page;
        public UserAndRolesPage userAndRolesPage;

        [SetUp]
        public void Setup()
        {
            Driver = new Browser().Driver;

            LoginPage = new LoginPage(Driver, true);
            ProjectsPage = new ProjectsPage(Driver);
            DashboardPage = new DashboardPage(Driver);
            dashboard_SearchProject_Page = new Dashboard_SearchProject_Page(Driver);
            userAndRolesPage = new UserAndRolesPage(Driver);

            _allure = AllureLifecycle.Instance;
        }

        [TearDown]
        public void TearDown()
        {
            // Проверка, что тест упал
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                // Создание скриншота
                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                byte[] screenshotBytes = screenshot.AsByteArray;

                // Прикрепление сриншота
                _allure.AddAttachment("Screenshot", "image/png", screenshotBytes);
            }

            //Driver.Quit();
            //Driver.Dispose();
        }
    }
}
