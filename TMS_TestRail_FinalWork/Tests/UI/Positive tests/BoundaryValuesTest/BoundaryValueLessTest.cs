using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Models;
using TMS_TestRail_FinalWork.Pages;

namespace TMS_TestRail_FinalWork.Tests.UI.Positive_tests.BoundaryValuesTest
{
    public class BoundaryValueLessTest : BaseTest
    {
        [Test(Description = "Limit value test")]
        [Category("Boundary Value Test")]
        [Description("The number of entered values does not exceed 250")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]
        public void BoundaryValeuLessThan_250_Test()
        {
            string searchProject = "The number of entered values is 34";

            User user = new UserBuilder()
                .SetUsername("nicolas.maliavko@gmail.com")
                .SetPassword("Qwer_1234")
                .Build();
            LoginPage.SuccessfulLogin(user)
                .NavigateToProjectCategorySearch()
                .EnterDataInSearchField(searchProject);

            Thread.Sleep(5000);

            Assert.IsFalse(dashboard_SearchProject_Page.IsPresentErrorLimitDialogMessage());
        }
    }
}
